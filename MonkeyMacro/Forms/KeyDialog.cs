using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MonkeyMacro.Forms
{
    public partial class KeyDialog : Form
    {
        private bool isDragging;
        private Point draggingStartPoint;

        private bool isKeyCapturing;
        private StringBuilder currentKeySequence;
        private StringBuilder lastKeySequence;
        private HashSet<Keys> pressedKeys;

        public string ShortcutName { get; set; }
        public KeyCombination KeyCombination { get; set; }

        public KeyCombination UpdatedKeyCombination { get; private set; }

        public KeyDialog(string keyName, KeyCombination keys)
        {
            this.ShortcutName = keyName;
            this.KeyCombination = keys;

            InitializeComponent();
            InitializeLayout();
            InitializeEventHandlers();
            InitializeKeyCaptureProperties();
        }

        private void InitializeKeyCaptureProperties()
        {
            currentKeySequence = new StringBuilder();
            lastKeySequence = new StringBuilder();
            isKeyCapturing = false;
            pressedKeys = new HashSet<Keys>();

            foreach (var key in KeyCombination.Keys)
            {
                lastKeySequence.Append(key + " + ");
            }
            // Remove the trailing " + "
            if (lastKeySequence.Length > 3)
            {
                lastKeySequence.Length -= 3;
            }
        }

        private void InitializeEventHandlers()
        {
            buttonEdit.Click += OnButtonEditClick;
            buttonSave.Click += OnButtonSaveClick;
            pictureBoxButtonExit.Click += OnPictureBoxButtonExitClick;
            pictureBoxButtonExit.MouseMove += OnPictureBoxButtonMove;

            panelTitleBar.MouseDown += OnPanelTitleBarMouseDown;
            panelTitleBar.MouseMove += OnPanelTitleBarMouseMove;
            panelTitleBar.MouseUp += OnPanelTitleBarMouseUp;
        }

        private void InitializeLayout()
        {
            textBoxKeyName.Text = ShortcutName;
            textBoxKeyCombination.Text = string.Join(" + ", KeyCombination.Keys);
            textBoxKeyCombination.Enabled = false;
        }

        private void OnPanelTitleBarMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                draggingStartPoint = new Point(e.X, e.Y);
            }
        }

        private void OnPanelTitleBarMouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void OnPanelTitleBarMouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - draggingStartPoint.X, point.Y - draggingStartPoint.Y);
            }
        }

        private void OnPictureBoxButtonExitClick(object sender, EventArgs e)
        {
            SetKeyCapturing();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OnPictureBoxButtonMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void OnButtonSaveClick(object sender, EventArgs e)
        {
            if (isKeyCapturing)
            {
                SetKeyCapturing();
            }

            this.ShortcutName = textBoxKeyName.Text;
            this.UpdatedKeyCombination = new KeyCombination { Keys = lastKeySequence.ToString().Split(new[] { " + " }, StringSplitOptions.RemoveEmptyEntries) };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void OnButtonEditClick(object sender, EventArgs e)
        {
            SetKeyCapturing();
        }

        private void SetKeyCapturing()
        {
            isKeyCapturing = !isKeyCapturing;
            buttonEdit.Text = isKeyCapturing ? "Stop" : "Edit";
            buttonEdit.BackColor = isKeyCapturing ? Color.FromArgb(44, 49, 58) : Color.FromArgb(81, 95, 115);
            textBoxKeyName.Enabled = !isKeyCapturing;
            textBoxKeyCombination.Enabled = isKeyCapturing;
            this.KeyPreview = isKeyCapturing;

            if (isKeyCapturing)
            {
                this.KeyDown += new KeyEventHandler(OnKeyDown);
                this.KeyUp += new KeyEventHandler(OnKeyUp);
            }
            else
            {
                this.KeyDown -= new KeyEventHandler(OnKeyDown);
                this.KeyUp -= new KeyEventHandler(OnKeyUp);
                pressedKeys.Clear();
            }
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (isKeyCapturing && !pressedKeys.Contains(e.KeyCode))
            {
                pressedKeys.Add(e.KeyCode);
                UpdateKeyCombinationDisplay();
            }
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (isKeyCapturing)
            {
                pressedKeys.Remove(e.KeyCode);
            }
        }

        private string GetKeyDisplayString(Keys key)
        {
            switch (key)
            {
                case Keys.ControlKey:
                    return "Ctrl";
                case Keys.ShiftKey:
                    return "Shift";
                case Keys.Menu:
                    return "Alt";
                case Keys.LWin:
                case Keys.RWin:
                    return "Win";
                case Keys.Oemcomma:
                    return "<";
                case Keys.OemPeriod:
                    return ">";
                default:
                    return key.ToString();
            }
        }

        private void UpdateKeyCombinationDisplay()
        {
            currentKeySequence.Clear();
            foreach (var key in pressedKeys)
            {
                currentKeySequence.Append(GetKeyDisplayString(key) + " + ");
            }
            // Remove the trailing " + "
            if (currentKeySequence.Length > 3)
            {
                currentKeySequence.Length -= 3;
            }
            textBoxKeyCombination.Text = currentKeySequence.ToString();
            lastKeySequence = new StringBuilder(currentKeySequence.ToString());
        }

        public static (string shortcutName, KeyCombination keyCombination, DialogResult dialogResult) ShowDialog(Form parentForm, string shortcutName, KeyCombination keys)
        {
            using (KeyDialog editDialog = new KeyDialog(shortcutName, keys))
            {
                editDialog.StartPosition = FormStartPosition.CenterParent;
                editDialog.TopMost = parentForm.TopMost;
                var result = editDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    return (editDialog.ShortcutName, editDialog.UpdatedKeyCombination, result);
                }

                return (shortcutName, keys, result);
            }
        }

    }
}
