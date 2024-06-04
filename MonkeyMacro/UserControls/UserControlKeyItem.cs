using MonkeyMacro.Forms;
using MonkeyMacro.Objects;
using System;
using System.Windows.Forms;

namespace MonkeyMacro.UserControls
{
    public partial class UserControlKeyItem : UserControl
    {
        public string TracingAppName { get; set; }
        public string ShortcutName { get; set; }
        public KeyCombination Keys { get; set; }

        FirebaseController firebaseController;

        public UserControlKeyItem(string tracingAppName, string shortcutName, KeyCombination keys)
        {
            this.TracingAppName = tracingAppName;
            this.ShortcutName = shortcutName;
            this.Keys = keys;

            InitializeComponent();
            InitializeEventHandlers();
            SetItemLayout();
        }

        private void InitializeEventHandlers()
        {
            pictureBoxButtonEdit.Click += OnPictureBoxButtonEditClick;
            pictureBoxButtonEdit.MouseMove += OnPictureBoxButtonMove;

            pictureBoxButtonDelete.Click += OnPictureBoxButtonDeleteClick;
            pictureBoxButtonDelete.MouseMove += OnPictureBoxButtonMove;
        }

        private void OnPictureBoxButtonEditClick(object sender, EventArgs e)
        {
            ShowEditDialog();
        }

        private async void OnPictureBoxButtonDeleteClick(object sender, EventArgs e)
        {
            bool confirmResult = AlertDialog.ShowDialog(this.ParentForm, "삭제 확인", "정말로 이 단축키를 삭제하시겠습니까?", "OK", "Cancel");
            if (confirmResult)
            {
                MainForm mainForm = this.TopLevelControl as MainForm;
                firebaseController = FirebaseController.Instance;
                bool success = await firebaseController.DeleteUserShortcut(mainForm.userDataStorage.UserName, TracingAppName, ShortcutName);

                if (success)
                {
                    // 로컬 데이터에서도 삭제
                    if (mainForm.userDataStorage.AppsShortcutDict.ContainsKey(TracingAppName))
                    {
                        var appShortcuts = mainForm.userDataStorage.AppsShortcutDict[TracingAppName];
                        appShortcuts.ShortcutKeys.Remove(ShortcutName);
                        if (appShortcuts.ShortcutKeys.Count == 0)
                        {
                            mainForm.userDataStorage.AppsShortcutDict.Remove(TracingAppName);
                        }
                    }

                    // 컨트롤 제거 및 레이아웃 다시 정렬
                    Control parentControl = this.Parent;
                    this.Parent.Controls.Remove(this);
                    this.Dispose();

                    // UserControlHome을 찾아서 레이아웃을 다시 그리도록 요청
                    UserControlHome homeControl = FindParentUserControlHome(parentControl);
                    if (homeControl != null)
                    {
                        homeControl.UpdateControl(TracingAppName, mainForm.userDataStorage.AppsShortcutDict);
                    }

                    MessageBox.Show("단축키가 삭제되었습니다.");
                }
                else
                {
                    MessageBox.Show("단축키 삭제 중 오류가 발생했습니다.");
                }
            }
        }

        private UserControlHome FindParentUserControlHome(Control control)
        {
            if (control == null)
            {
                return null;
            }

            if (control is UserControlHome homeControl)
            {
                return homeControl;
            }

            return FindParentUserControlHome(control.Parent);
        }



        private async void ShowEditDialog()
        {
            var (updatedShortcutName, updatedKeys, dialogResult) = KeyDialog.ShowDialog(ParentForm, this.ShortcutName, this.Keys);
            if (dialogResult == DialogResult.OK && updatedShortcutName != null && updatedKeys != null)
            {
                string oldShortcutName = this.ShortcutName;
                UpdateItem(updatedShortcutName, updatedKeys);

                MainForm mainForm = this.TopLevelControl as MainForm;
                mainForm.userDataStorage.ModifyApplicationShortcut(TracingAppName, oldShortcutName, updatedShortcutName, updatedKeys);

                firebaseController = FirebaseController.Instance;
                bool success = await firebaseController.ModifyUserShortcut(mainForm.userDataStorage.UserName, TracingAppName, oldShortcutName, updatedShortcutName, updatedKeys.Keys);

                if (!success)
                {
                    MessageBox.Show("단축키 수정 중 오류가 발생했습니다.");
                }
            }
        }


        private void OnPictureBoxButtonMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void SetItemLayout()
        {
            UserControlStyler.ApplyRoundedCorners(this, 20, 20);
            labelShortcutName.Text = ShortcutName;
            textBoxKeyCombination.Text = string.Join(" + ", Keys.Keys);
            textBoxKeyCombination.Enabled = false;
        }

        public void UpdateItem(string shortcutName, KeyCombination keys)
        {
            this.ShortcutName = shortcutName;
            this.Keys = keys;
            SetItemLayout();
        }
    }
}
