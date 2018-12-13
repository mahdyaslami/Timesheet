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
            selectedFilenameTextBox.Text = Properties.Settings.Default.Filename;
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
            if (string.IsNullOrEmpty(selectedFilenameTextBox.Text))
            {
                MessageBox.Show(Properties.Resources.DBFileIsNotSelected,
                    Properties.Resources.MsgBoxCaption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
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
                DatabaseProvider.SetServerConnectionStringToDefault();
                SaveSetting();
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else
            {
                try
                {
                    DatabaseProvider.SetFileConnectionString(
                        selectedFilenameTextBox.Text);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    SaveSetting();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        Properties.Resources.MsgBoxCaption,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
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
            if (string.IsNullOrEmpty(selectedFilenameTextBox.Text))
            {
                MessageBox.Show(Properties.Resources.DBFileIsNotSelected,
                    Properties.Resources.MsgBoxCaption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
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
        }

        private void isServerDBUsedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool b = isServerDBUsedCheckBox.Checked;
            ChangeAthenticationCheckBoxAndTestButtonEnabled(b);
            ChangeServerAndDatabaseTextBoxesEnabled(b);
        }

        private void ChangeUserIDAndPaswordTextBoxesEnabled(bool enabled)
        {
            usernameTextBox.Enabled = enabled;
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
            Properties.Settings.Default.Filename = selectedFilenameTextBox.Text;
            Properties.Settings.Default.Save();
        }
    }
}
