using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace KeyCaptureApp
{
    public partial class KeyCaptureExample : Form
    {
        private StringBuilder keySequence;
        private bool isCapturing;
        private HashSet<Keys> pressedKeys;

        public KeyCaptureExample()
        {
            InitializeComponent();
            keySequence = new StringBuilder();
            isCapturing = false;
            pressedKeys = new HashSet<Keys>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isCapturing)
            {
                isCapturing = true;
                buttonKeyCapture.Text = "키 캡쳐 중단";
                this.KeyPreview = true;
                this.KeyDown += new KeyEventHandler(Form1_KeyDown);
                this.KeyUp += new KeyEventHandler(Form1_KeyUp);
            }
            else
            {
                isCapturing = false;
                buttonKeyCapture.Text = "키 캡쳐 시작";
                this.KeyPreview = false;
                this.KeyDown -= new KeyEventHandler(Form1_KeyDown);
                this.KeyUp -= new KeyEventHandler(Form1_KeyUp);
                pressedKeys.Clear();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (isCapturing && !pressedKeys.Contains(e.KeyCode))
            {
                pressedKeys.Add(e.KeyCode);
                string key = GetKeyDisplayString(e.KeyCode);
                keySequence.Append(key + " + ");
                UpdateLabel();
            }
        }

        private void UpdateLabel()
        {
            string displayText = $"단축키 : {keySequence.ToString()}";
            if (displayText.EndsWith(" + "))
            {
                displayText = displayText.Substring(0, displayText.Length - 3);
            }
            labelCapturedKeys.Text = displayText;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (isCapturing)
            {
                pressedKeys.Remove(e.KeyCode);
                keySequence.Clear();
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
    }
}