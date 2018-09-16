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
                return inputTextBox.Text;
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
    }
}
