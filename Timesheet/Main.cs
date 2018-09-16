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

    }
}
