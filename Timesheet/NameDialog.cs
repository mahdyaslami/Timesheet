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
    public partial class NameDialog : Form
    {
        private string emptyStringOrWhiteSpaceErrorMessage;
        
        public NameDialog(string caption, string messagetext,
            RightToLeft messageRightToLeft, ContentAlignment messageAlign,
            string emptyStringOrWhiteSpaceErrorMessage = null)
        {
            InitializeComponent();

            Caption = caption;
            MessageText = messagetext;
            MessageRightToLeft = messageRightToLeft;
            MessageAlign = messageAlign;
            if (string.IsNullOrWhiteSpace(emptyStringOrWhiteSpaceErrorMessage))
            {
                this.emptyStringOrWhiteSpaceErrorMessage = "Input cann't be empty or white space.";
            }
            else
            {
                this.emptyStringOrWhiteSpaceErrorMessage = emptyStringOrWhiteSpaceErrorMessage;
            }
        }

        public string Caption
        {
            get
            {
                return this.Text;
            }
            set
            {
                this.Text = value;
            }
        }

        public string MessageText
        {
            get
            {
                return messageLabel.Text;
            }
            set
            {
                messageLabel.Text = value;
            }
        }

        public RightToLeft MessageRightToLeft
        {
            get
            {
                return messageLabel.RightToLeft;
            }
            set
            {
                messageLabel.RightToLeft = RightToLeft;
            }
        }

        public ContentAlignment MessageAlign
        {
            get
            {
                return messageLabel.TextAlign;
            }
            set
            {
                messageLabel.TextAlign = value;
            }
        }

        public string Input
        {
            get
            {
                return EqualizePersianString(inputTextBox.Text);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputTextBox.Text))
            {
                MessageBox.Show(emptyStringOrWhiteSpaceErrorMessage, Caption
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = string.Empty;
            this.Close();
        }

        /// <summary>
        /// یک متن را می گیرید و اگر داخل آن ی و ک عربی به کار برده شده باشد آن را به فارسی تغییر می دهد و بر می گرداند
        /// </summary>
        /// <param name="str">مقداری که حاوی ی و ک عربی است</param>
        /// <returns>مقداری که ی و ک عربی آن به فارسی تغییر پیدا کرده است</returns>
        public string EqualizePersianString(string str)
        {
            // select nchar(1610) as arabic, nchar(1740) as persian - > ی
            // select nchar(1603) as arabic, nchar(1705) as persian - > ک
            return str.Replace("ي", "ی").Replace("ك", "ک"); ;
        }
    }
}
