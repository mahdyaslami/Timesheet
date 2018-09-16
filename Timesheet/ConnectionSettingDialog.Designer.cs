namespace Makh.Timesheet
{
    partial class ConnectionSettingDialog
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.fileTabPage = new System.Windows.Forms.TabPage();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.selectedFilenameTextBox = new System.Windows.Forms.TextBox();
            this.testFileConnectionButton = new System.Windows.Forms.Button();
            this.serverTabPage = new System.Windows.Forms.TabPage();
            this.testServerConnectionButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.isUserPasswordNeedCheckBox = new System.Windows.Forms.CheckBox();
            this.databaseNameLabel = new System.Windows.Forms.Label();
            this.databaseNameTextBox = new System.Windows.Forms.TextBox();
            this.serverAddressLabel = new System.Windows.Forms.Label();
            this.serverAddressTextBox = new System.Windows.Forms.TextBox();
            this.isServerDBUsedCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.setToDefaultButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.fileTabPage.SuspendLayout();
            this.serverTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.fileTabPage);
            this.tabControl.Controls.Add(this.serverTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(460, 306);
            this.tabControl.TabIndex = 0;
            // 
            // fileTabPage
            // 
            this.fileTabPage.Controls.Add(this.setToDefaultButton);
            this.fileTabPage.Controls.Add(this.selectFileButton);
            this.fileTabPage.Controls.Add(this.selectedFilenameTextBox);
            this.fileTabPage.Controls.Add(this.testFileConnectionButton);
            this.fileTabPage.Location = new System.Drawing.Point(4, 28);
            this.fileTabPage.Name = "fileTabPage";
            this.fileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.fileTabPage.Size = new System.Drawing.Size(452, 274);
            this.fileTabPage.TabIndex = 0;
            this.fileTabPage.Text = "فایل";
            this.fileTabPage.UseVisualStyleBackColor = true;
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(301, 81);
            this.selectFileButton.Margin = new System.Windows.Forms.Padding(10);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(130, 27);
            this.selectFileButton.TabIndex = 31;
            this.selectFileButton.Text = "انتخاب فایل";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // selectedFilenameTextBox
            // 
            this.selectedFilenameTextBox.Location = new System.Drawing.Point(30, 81);
            this.selectedFilenameTextBox.Name = "selectedFilenameTextBox";
            this.selectedFilenameTextBox.ReadOnly = true;
            this.selectedFilenameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectedFilenameTextBox.Size = new System.Drawing.Size(258, 27);
            this.selectedFilenameTextBox.TabIndex = 30;
            // 
            // testFileConnectionButton
            // 
            this.testFileConnectionButton.Location = new System.Drawing.Point(13, 234);
            this.testFileConnectionButton.Margin = new System.Windows.Forms.Padding(10);
            this.testFileConnectionButton.Name = "testFileConnectionButton";
            this.testFileConnectionButton.Size = new System.Drawing.Size(130, 27);
            this.testFileConnectionButton.TabIndex = 29;
            this.testFileConnectionButton.Text = "تست اتصال";
            this.testFileConnectionButton.UseVisualStyleBackColor = true;
            this.testFileConnectionButton.Click += new System.EventHandler(this.testFileConnectionButton_Click);
            // 
            // serverTabPage
            // 
            this.serverTabPage.Controls.Add(this.testServerConnectionButton);
            this.serverTabPage.Controls.Add(this.passwordLabel);
            this.serverTabPage.Controls.Add(this.passwordTextBox);
            this.serverTabPage.Controls.Add(this.usernameLabel);
            this.serverTabPage.Controls.Add(this.usernameTextBox);
            this.serverTabPage.Controls.Add(this.isUserPasswordNeedCheckBox);
            this.serverTabPage.Controls.Add(this.databaseNameLabel);
            this.serverTabPage.Controls.Add(this.databaseNameTextBox);
            this.serverTabPage.Controls.Add(this.serverAddressLabel);
            this.serverTabPage.Controls.Add(this.serverAddressTextBox);
            this.serverTabPage.Controls.Add(this.isServerDBUsedCheckBox);
            this.serverTabPage.Location = new System.Drawing.Point(4, 28);
            this.serverTabPage.Name = "serverTabPage";
            this.serverTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.serverTabPage.Size = new System.Drawing.Size(452, 274);
            this.serverTabPage.TabIndex = 1;
            this.serverTabPage.Text = "سرور";
            this.serverTabPage.UseVisualStyleBackColor = true;
            // 
            // testServerConnectionButton
            // 
            this.testServerConnectionButton.Location = new System.Drawing.Point(13, 234);
            this.testServerConnectionButton.Margin = new System.Windows.Forms.Padding(10);
            this.testServerConnectionButton.Name = "testServerConnectionButton";
            this.testServerConnectionButton.Size = new System.Drawing.Size(130, 27);
            this.testServerConnectionButton.TabIndex = 30;
            this.testServerConnectionButton.Text = "تست اتصال";
            this.testServerConnectionButton.UseVisualStyleBackColor = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(291, 175);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(67, 19);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "کلمه عبور:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(135, 172);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(150, 27);
            this.passwordTextBox.TabIndex = 8;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(291, 142);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(65, 19);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "نام کاربری:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(135, 139);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(150, 27);
            this.usernameTextBox.TabIndex = 6;
            // 
            // isUserPasswordNeedCheckBox
            // 
            this.isUserPasswordNeedCheckBox.AutoSize = true;
            this.isUserPasswordNeedCheckBox.Location = new System.Drawing.Point(283, 116);
            this.isUserPasswordNeedCheckBox.Name = "isUserPasswordNeedCheckBox";
            this.isUserPasswordNeedCheckBox.Size = new System.Drawing.Size(129, 23);
            this.isUserPasswordNeedCheckBox.TabIndex = 5;
            this.isUserPasswordNeedCheckBox.Text = "نیاز به احراز هویت";
            this.isUserPasswordNeedCheckBox.UseVisualStyleBackColor = true;
            // 
            // databaseNameLabel
            // 
            this.databaseNameLabel.AutoSize = true;
            this.databaseNameLabel.Location = new System.Drawing.Point(339, 65);
            this.databaseNameLabel.Name = "databaseNameLabel";
            this.databaseNameLabel.Size = new System.Drawing.Size(87, 19);
            this.databaseNameLabel.TabIndex = 4;
            this.databaseNameLabel.Text = "نام پایگاه داده:";
            // 
            // databaseNameTextBox
            // 
            this.databaseNameTextBox.Location = new System.Drawing.Point(183, 62);
            this.databaseNameTextBox.Name = "databaseNameTextBox";
            this.databaseNameTextBox.Size = new System.Drawing.Size(150, 27);
            this.databaseNameTextBox.TabIndex = 3;
            // 
            // serverAddressLabel
            // 
            this.serverAddressLabel.AutoSize = true;
            this.serverAddressLabel.Location = new System.Drawing.Point(339, 32);
            this.serverAddressLabel.Name = "serverAddressLabel";
            this.serverAddressLabel.Size = new System.Drawing.Size(75, 19);
            this.serverAddressLabel.TabIndex = 2;
            this.serverAddressLabel.Text = "آدرس سرور:";
            // 
            // serverAddressTextBox
            // 
            this.serverAddressTextBox.Location = new System.Drawing.Point(183, 29);
            this.serverAddressTextBox.Name = "serverAddressTextBox";
            this.serverAddressTextBox.Size = new System.Drawing.Size(150, 27);
            this.serverAddressTextBox.TabIndex = 1;
            // 
            // isServerDBUsedCheckBox
            // 
            this.isServerDBUsedCheckBox.AutoSize = true;
            this.isServerDBUsedCheckBox.Location = new System.Drawing.Point(331, 6);
            this.isServerDBUsedCheckBox.Name = "isServerDBUsedCheckBox";
            this.isServerDBUsedCheckBox.Size = new System.Drawing.Size(115, 23);
            this.isServerDBUsedCheckBox.TabIndex = 0;
            this.isServerDBUsedCheckBox.Text = "استفاده از سرور";
            this.isServerDBUsedCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(385, 323);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 27);
            this.saveButton.TabIndex = 27;
            this.saveButton.Text = "ذخیره";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(299, 323);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(80, 27);
            this.closeButton.TabIndex = 28;
            this.closeButton.Text = "بستن";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "sqlserverdb|*.mdf";
            // 
            // setToDefaultButton
            // 
            this.setToDefaultButton.Location = new System.Drawing.Point(148, 234);
            this.setToDefaultButton.Margin = new System.Windows.Forms.Padding(10);
            this.setToDefaultButton.Name = "setToDefaultButton";
            this.setToDefaultButton.Size = new System.Drawing.Size(130, 27);
            this.setToDefaultButton.TabIndex = 32;
            this.setToDefaultButton.Text = "برگشت به پیش فرض";
            this.setToDefaultButton.UseVisualStyleBackColor = true;
            this.setToDefaultButton.Click += new System.EventHandler(this.setToDefaultButton_Click);
            // 
            // ConnectionSettingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionSettingDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConnectionSetting";
            this.tabControl.ResumeLayout(false);
            this.fileTabPage.ResumeLayout(false);
            this.fileTabPage.PerformLayout();
            this.serverTabPage.ResumeLayout(false);
            this.serverTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage fileTabPage;
        private System.Windows.Forms.TabPage serverTabPage;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button testFileConnectionButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox selectedFilenameTextBox;
        private System.Windows.Forms.Button testServerConnectionButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.CheckBox isUserPasswordNeedCheckBox;
        private System.Windows.Forms.Label databaseNameLabel;
        private System.Windows.Forms.TextBox databaseNameTextBox;
        private System.Windows.Forms.Label serverAddressLabel;
        private System.Windows.Forms.TextBox serverAddressTextBox;
        private System.Windows.Forms.CheckBox isServerDBUsedCheckBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button setToDefaultButton;
    }
}