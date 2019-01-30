using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makh.Timesheet
{
    public partial class ConnectionSettingDialog : Form
    {
        public ConnectionSettingDialog()
        {
            InitializeComponent();
        }

        private void LoadSetting()
        {
            this.selectedFilenameTextBox.Text =
                Properties.Settings.Default.DBFilename;

            if (string.IsNullOrWhiteSpace(
                    Properties.Settings.Default.ServerAddress) == false
                && string.IsNullOrWhiteSpace(
                    Properties.Settings.Default.DatabaseName) == false)
            {
                this.isServerDBUsedCheckBox.Checked = true;

                this.serverAddressTextBox.Text =
                    Properties.Settings.Default.ServerAddress;
                this.databaseNameTextBox.Text =
                    Properties.Settings.Default.DatabaseName;
            }
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                selectedFilenameTextBox.Text = openFileDialog.FileName;
            }
        }

        private void testFileConnectionButton_Click(object sender, EventArgs e)
        {
            Exception exception;
            if (DatabaseProvider.TestFileConnection(selectedFilenameTextBox.Text, out exception))
            {
                MessageBox.Show(Properties.Resources.TestConnectionSucceeded,
                    Properties.Resources.MsgBoxCaption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(exception.Message,
                    Properties.Resources.MsgBoxCaption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(selectedFilenameTextBox.Text))
                {
                    DatabaseProvider.SetFileConnectionStringToDefault();
                    SaveSetting();
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    Close();
                }
                else
                {
                    DatabaseProvider.SetFileConnectionString(
                        selectedFilenameTextBox.Text);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    SaveSetting();
                    Close();
                }

                if (isServerDBUsedCheckBox.Checked)
                {
                    if (isUserPasswordNeedCheckBox.Checked)
                    {
                        DatabaseProvider.SetServerConnectionString(
                            serverAddressTextBox.Text,
                            databaseNameTextBox.Text,
                            userIdTextBox.Text,
                            passwordTextBox.Text);
                    }
                    else
                    {
                        DatabaseProvider.SetServerConnectionString(
                            serverAddressTextBox.Text,
                            databaseNameTextBox.Text);
                    }
                    
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    userIdTextBox.Text = string.Empty;
                    passwordTextBox.Text = string.Empty;
                    SaveSetting();
                    Close();
                }
                else
                {
                    DatabaseProvider.RemoveServerConnectionString();
                    serverAddressTextBox.Text = string.Empty;
                    databaseNameTextBox.Text = string.Empty;
                    userIdTextBox.Text = string.Empty;
                    passwordTextBox.Text = string.Empty;
                    SaveSetting();
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    Properties.Resources.MsgBoxCaption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void setToDefaultButton_Click(object sender, EventArgs e)
        {
            selectedFilenameTextBox.Text = string.Empty;
        }

        private void testServerConnectionButton_Click(object sender, EventArgs e)
        {
            Exception exception = null;
            if (isUserPasswordNeedCheckBox.Checked
                && DatabaseProvider.TestServerConnection(serverAddressTextBox.Text,
                    databaseNameTextBox.Text, userIdTextBox.Text, passwordTextBox.Text, out exception))
            {
                MessageBox.Show(Properties.Resources.TestConnectionSucceeded,
                    Properties.Resources.MsgBoxCaption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (isUserPasswordNeedCheckBox.Checked == false
                && DatabaseProvider.TestServerConnection(serverAddressTextBox.Text,
                    databaseNameTextBox.Text, out exception))
            {
                MessageBox.Show(Properties.Resources.TestConnectionSucceeded,
                    Properties.Resources.MsgBoxCaption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(exception.Message,
                    Properties.Resources.MsgBoxCaption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void isServerDBUsedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool b = isServerDBUsedCheckBox.Checked;
            ChangeAthenticationCheckBoxAndTestButtonEnabled(b);
            ChangeServerAndDatabaseTextBoxesEnabled(b);
        }

        private void ChangeUserIDAndPaswordTextBoxesEnabled(bool enabled)
        {
            userIdTextBox.Enabled = enabled;
            passwordTextBox.Enabled = enabled;
        }

        private void ChangeAthenticationCheckBoxAndTestButtonEnabled(bool enabled)
        {
            isUserPasswordNeedCheckBox.Enabled = enabled;
            testServerConnectionButton.Enabled = enabled;
        }

        private void ChangeServerAndDatabaseTextBoxesEnabled(bool enabled)
        {
            serverAddressTextBox.Enabled = enabled;
            databaseNameTextBox.Enabled = enabled;
        }

        private void isUserPasswordNeedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ChangeUserIDAndPaswordTextBoxesEnabled(
                isUserPasswordNeedCheckBox.Checked);
        }

        private void isUserPasswordNeedCheckBox_EnabledChanged(object sender, EventArgs e)
        {
            ChangeUserIDAndPaswordTextBoxesEnabled(
                isUserPasswordNeedCheckBox.Enabled & isUserPasswordNeedCheckBox.Checked);
        }

        private void SaveSetting()
        {
            Properties.Settings.Default.DBFilename = selectedFilenameTextBox.Text;
            Properties.Settings.Default.ServerAddress = serverAddressTextBox.Text;
            Properties.Settings.Default.DatabaseName = databaseNameTextBox.Text;
            Properties.Settings.Default.UserId = userIdTextBox.Text;
            Properties.Settings.Default.Password = passwordTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void BindSavedValue()
        {
            selectedFilenameTextBox.Text = Properties.Settings.Default.DBFilename;
            serverAddressTextBox.Text = Properties.Settings.Default.ServerAddress;
            databaseNameTextBox.Text = Properties.Settings.Default.DatabaseName;
            userIdTextBox.Text = Properties.Settings.Default.UserId;
            passwordTextBox.Text = Properties.Settings.Default.Password;
        }

        private void ConnectionSettingDialog_Load(object sender, EventArgs e)
        {
            LoadSetting();
        }
    }
}
