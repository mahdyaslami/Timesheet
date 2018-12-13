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
            // نمایش نام کاربری بالای پنجره اول - اصلی
            this.Text = string.Format(
                Properties.Settings.Default.MainTextPattern,
                Program.Username);
        }

        private void connectionSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new ConnectionSettingDialog()).ShowDialog(this);
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Groups()).ShowDialog(this);
        }

        /// <summary>
        /// بررسی اتصال به پایگاه داده
        /// </summary>
        /// <remarks>
        /// بررسی می کند اگر اتصال به سرور وجود داشت در بالای نام می نویسد انلاین در غیر این صورت می نویسد افلاین
        /// سپس بررسی می کند آیا اتصال به فایل وجود دارد اگر وجود داشت که هیچ درغیر این صورت خطا پرتاب می کند و  از کاربر می خواهد که فایل درست را از منو کانکشن استرین انتخاب کند
        /// </remarks>
        public void TestConnection()
        {
            throw new System.NotImplementedException();
        }

        private void SetSetting()
        {
            if (string.IsNullOrWhiteSpace(
                Properties.Settings.Default.Filename))
            {
                DatabaseProvider.SetFileConnectionString(
                    Properties.Settings.Default.Filename);
            }

            
        }
    }
}
