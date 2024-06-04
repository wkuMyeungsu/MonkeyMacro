namespace MonkeyMacro.Forms
{
    partial class KeyDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxButtonExit = new System.Windows.Forms.PictureBox();
            this.labelKeyName = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxKeyName = new System.Windows.Forms.TextBox();
            this.textBoxKeyCombination = new System.Windows.Forms.TextBox();
            this.labelKeyCombination = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonExit)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxButtonExit
            // 
            this.pictureBoxButtonExit.Image = global::MonkeyMacro.Properties.Resources.white_cross;
            this.pictureBoxButtonExit.Location = new System.Drawing.Point(278, 7);
            this.pictureBoxButtonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxButtonExit.Name = "pictureBoxButtonExit";
            this.pictureBoxButtonExit.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxButtonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButtonExit.TabIndex = 4;
            this.pictureBoxButtonExit.TabStop = false;
            // 
            // labelKeyName
            // 
            this.labelKeyName.AutoSize = true;
            this.labelKeyName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeyName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelKeyName.Location = new System.Drawing.Point(23, 46);
            this.labelKeyName.Name = "labelKeyName";
            this.labelKeyName.Size = new System.Drawing.Size(81, 27);
            this.labelKeyName.TabIndex = 5;
            this.labelKeyName.Text = "Name";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.buttonSave.FlatAppearance.BorderSize = 2;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(28, 393);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(243, 35);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // textBoxKeyName
            // 
            this.textBoxKeyName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxKeyName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyName.Location = new System.Drawing.Point(26, 83);
            this.textBoxKeyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKeyName.Name = "textBoxKeyName";
            this.textBoxKeyName.Size = new System.Drawing.Size(245, 32);
            this.textBoxKeyName.TabIndex = 20;
            this.textBoxKeyName.Text = "Paste";
            // 
            // textBoxKeyCombination
            // 
            this.textBoxKeyCombination.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxKeyCombination.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyCombination.Location = new System.Drawing.Point(26, 202);
            this.textBoxKeyCombination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKeyCombination.Name = "textBoxKeyCombination";
            this.textBoxKeyCombination.ReadOnly = true;
            this.textBoxKeyCombination.Size = new System.Drawing.Size(245, 32);
            this.textBoxKeyCombination.TabIndex = 22;
            this.textBoxKeyCombination.Text = "Ctrl + V";
            // 
            // labelKeyCombination
            // 
            this.labelKeyCombination.AutoSize = true;
            this.labelKeyCombination.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeyCombination.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelKeyCombination.Location = new System.Drawing.Point(23, 165);
            this.labelKeyCombination.Name = "labelKeyCombination";
            this.labelKeyCombination.Size = new System.Drawing.Size(207, 27);
            this.labelKeyCombination.TabIndex = 21;
            this.labelKeyCombination.Text = "Key Combination";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(95)))), ((int)(((byte)(115)))));
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(95)))), ((int)(((byte)(115)))));
            this.buttonEdit.FlatAppearance.BorderSize = 2;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(171, 242);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 35);
            this.buttonEdit.TabIndex = 23;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(37)))), ((int)(((byte)(61)))));
            this.panelTitleBar.Controls.Add(this.pictureBoxButtonExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(299, 33);
            this.panelTitleBar.TabIndex = 24;
            // 
            // KeyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(67)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(299, 450);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxKeyCombination);
            this.Controls.Add(this.labelKeyCombination);
            this.Controls.Add(this.textBoxKeyName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelKeyName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KeyDialog";
            this.Text = "AddItemDialoig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonExit)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxButtonExit;
        private System.Windows.Forms.Label labelKeyName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxKeyName;
        private System.Windows.Forms.TextBox textBoxKeyCombination;
        private System.Windows.Forms.Label labelKeyCombination;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Panel panelTitleBar;
    }
}