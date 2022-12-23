namespace PassGen.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelHeader = new System.Windows.Forms.Label();
            this.pictureBoxApplicationExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPasswordLength = new System.Windows.Forms.TextBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.checkBoxUseNumbers = new System.Windows.Forms.CheckBox();
            this.checkBoxUseUpperCase = new System.Windows.Forms.CheckBox();
            this.checkBoxUseLowerCase = new System.Windows.Forms.CheckBox();
            this.checkBoxUseSpecialSymbols = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApplicationExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(347, 25);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Passwords generator";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxApplicationExit
            // 
            this.pictureBoxApplicationExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxApplicationExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            this.pictureBoxApplicationExit.Location = new System.Drawing.Point(322, 0);
            this.pictureBoxApplicationExit.Name = "pictureBoxApplicationExit";
            this.pictureBoxApplicationExit.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxApplicationExit.TabIndex = 1;
            this.pictureBoxApplicationExit.TabStop = false;
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(67)))));
            this.pictureBoxMinimize.Location = new System.Drawing.Point(297, 0);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxMinimize.TabIndex = 1;
            this.pictureBoxMinimize.TabStop = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.textBoxPassword.Location = new System.Drawing.Point(12, 129);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(323, 20);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.TabStop = false;
            // 
            // textBoxPasswordLength
            // 
            this.textBoxPasswordLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.textBoxPasswordLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPasswordLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.textBoxPasswordLength.Location = new System.Drawing.Point(265, 37);
            this.textBoxPasswordLength.Name = "textBoxPasswordLength";
            this.textBoxPasswordLength.Size = new System.Drawing.Size(70, 20);
            this.textBoxPasswordLength.TabIndex = 4;
            this.textBoxPasswordLength.TabStop = false;
            this.textBoxPasswordLength.Text = "50";
            this.textBoxPasswordLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPasswordLength.TextChanged += new System.EventHandler(this.TextBoxPasswordLength_TextChanged);
            this.textBoxPasswordLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPasswordLength_KeyPress);
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(219, 39);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(40, 13);
            this.labelLength.TabIndex = 4;
            this.labelLength.Text = "Length";
            // 
            // checkBoxUseNumbers
            // 
            this.checkBoxUseNumbers.AutoSize = true;
            this.checkBoxUseNumbers.Checked = true;
            this.checkBoxUseNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseNumbers.Location = new System.Drawing.Point(12, 37);
            this.checkBoxUseNumbers.Name = "checkBoxUseNumbers";
            this.checkBoxUseNumbers.Size = new System.Drawing.Size(88, 17);
            this.checkBoxUseNumbers.TabIndex = 0;
            this.checkBoxUseNumbers.TabStop = false;
            this.checkBoxUseNumbers.Text = "Use numbers";
            this.checkBoxUseNumbers.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseUpperCase
            // 
            this.checkBoxUseUpperCase.AutoSize = true;
            this.checkBoxUseUpperCase.Checked = true;
            this.checkBoxUseUpperCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseUpperCase.Location = new System.Drawing.Point(12, 60);
            this.checkBoxUseUpperCase.Name = "checkBoxUseUpperCase";
            this.checkBoxUseUpperCase.Size = new System.Drawing.Size(111, 17);
            this.checkBoxUseUpperCase.TabIndex = 1;
            this.checkBoxUseUpperCase.TabStop = false;
            this.checkBoxUseUpperCase.Text = "Use UPPER case";
            this.checkBoxUseUpperCase.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseLowerCase
            // 
            this.checkBoxUseLowerCase.AutoSize = true;
            this.checkBoxUseLowerCase.Checked = true;
            this.checkBoxUseLowerCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseLowerCase.Location = new System.Drawing.Point(12, 83);
            this.checkBoxUseLowerCase.Name = "checkBoxUseLowerCase";
            this.checkBoxUseLowerCase.Size = new System.Drawing.Size(99, 17);
            this.checkBoxUseLowerCase.TabIndex = 2;
            this.checkBoxUseLowerCase.TabStop = false;
            this.checkBoxUseLowerCase.Text = "Use lower case";
            this.checkBoxUseLowerCase.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseSpecialSymbols
            // 
            this.checkBoxUseSpecialSymbols.AutoSize = true;
            this.checkBoxUseSpecialSymbols.Checked = true;
            this.checkBoxUseSpecialSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseSpecialSymbols.Location = new System.Drawing.Point(12, 106);
            this.checkBoxUseSpecialSymbols.Name = "checkBoxUseSpecialSymbols";
            this.checkBoxUseSpecialSymbols.Size = new System.Drawing.Size(121, 17);
            this.checkBoxUseSpecialSymbols.TabIndex = 3;
            this.checkBoxUseSpecialSymbols.TabStop = false;
            this.checkBoxUseSpecialSymbols.Text = "Use special symbols";
            this.checkBoxUseSpecialSymbols.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(347, 161);
            this.ControlBox = false;
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.textBoxPasswordLength);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.checkBoxUseSpecialSymbols);
            this.Controls.Add(this.checkBoxUseLowerCase);
            this.Controls.Add(this.checkBoxUseUpperCase);
            this.Controls.Add(this.checkBoxUseNumbers);
            this.Controls.Add(this.pictureBoxMinimize);
            this.Controls.Add(this.pictureBoxApplicationExit);
            this.Controls.Add(this.labelHeader);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(173)))), ((int)(((byte)(180)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passwords generator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApplicationExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBoxApplicationExit;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPasswordLength;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.CheckBox checkBoxUseNumbers;
        private System.Windows.Forms.CheckBox checkBoxUseUpperCase;
        private System.Windows.Forms.CheckBox checkBoxUseLowerCase;
        private System.Windows.Forms.CheckBox checkBoxUseSpecialSymbols;
    }
}

