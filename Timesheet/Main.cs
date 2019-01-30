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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            RefreshSettingAndAppearance();
        }

        private void connectionSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((new ConnectionSettingDialog()).ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                RefreshSettingAndAppearance();
            }
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Groups()).ShowDialog(this);
        }

        /// <summary>
        /// تنظیمات را لود می کند و در صورت بروز خطا پیام مناسب را نمایش می دهد
        /// </summary>
        /// <remarks>
        /// تنظیمات پایگاه داده را می خواند و اعمال می کند
        /// </remarks>
        private void LoadSetting()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    Properties.Settings.Default.DBFilename) == false)
                {
                    DatabaseProvider.SetFileConnectionString(
                        Properties.Settings.Default.DBFilename);
                }
            }
            catch
            {
                MessageBox.Show(
                    Properties.Resources.ReturnFileSettingToDefault
                    , Properties.Resources.MsgBoxCaption
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                DatabaseProvider.SetFileConnectionStringToDefault();
            }

            try
            {
                if (string.IsNullOrWhiteSpace(
                        Properties.Settings.Default.ServerAddress) == false)
                {
                    if (string.IsNullOrWhiteSpace(
                            Properties.Settings.Default.UserId)
                        || string.IsNullOrWhiteSpace(
                            Properties.Settings.Default.Password))
                    {
                        DatabaseProvider.SetServerConnectionString(
                            Properties.Settings.Default.ServerAddress,
                            Properties.Settings.Default.DatabaseName);
                    }
                    else
                    {
                        DatabaseProvider.SetServerConnectionString(
                            Properties.Settings.Default.ServerAddress,
                            Properties.Settings.Default.DatabaseName,
                            Properties.Settings.Default.UserId,
                            Properties.Settings.Default.Password);
                    }
                }
            }
            catch
            {
                MessageBox.Show(
                    Properties.Resources.ReturnServerSettingToDefault
                    , Properties.Resources.MsgBoxCaption
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                DatabaseProvider.RemoveServerConnectionString();
            }
        }

        /// <summary>
        /// تنظیمات را دوباره می خواند و اعمال می کند 
        /// و ظاهر را بر اساس تنظمیات جدید بروزرسانی می کند
        /// </summary>
        private void RefreshSettingAndAppearance()
        {
            LoadSetting();

            // نمایش نام کاربری بالای پنجره اول - اصلی
            this.Text = string.Format(
                Properties.Settings.Default.MainTextPattern,
                Program.Username,
                DatabaseProvider.HasServer ? Properties.Resources.ONLINE : Properties.Resources.OFFLINE);
        }
    }
}
