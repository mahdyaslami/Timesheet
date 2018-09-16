namespace Makh.Timesheet
{
    partial class Work
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
            this.endTime = new System.Windows.Forms.MaskedTextBox();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.MaskedTextBox();
            this.startTime = new System.Windows.Forms.MaskedTextBox();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.MaskedTextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.selectGroup = new System.Windows.Forms.Button();
            this.groupLabel = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.TextBox();
            this.addNewWork = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // endTime
            // 
            this.endTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTime.Location = new System.Drawing.Point(224, 67);
            this.endTime.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.endTime.Mask = "00:00";
            this.endTime.Name = "endTime";
            this.endTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.endTime.Size = new System.Drawing.Size(47, 27);
            this.endTime.TabIndex = 12;
            this.endTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endTime.ValidatingType = typeof(System.DateTime);
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(407, 70);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.endDateLabel.Size = new System.Drawing.Size(38, 19);
            this.endDateLabel.TabIndex = 10;
            this.endDateLabel.Text = "پایان:";
            // 
            // endDate
            // 
            this.endDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.Location = new System.Drawing.Point(281, 67);
            this.endDate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.endDate.Mask = "00/00/0000";
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(88, 27);
            this.endDate.TabIndex = 11;
            this.endDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endDate.ValidatingType = typeof(System.DateTime);
            // 
            // startTime
            // 
            this.startTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTime.Location = new System.Drawing.Point(224, 32);
            this.startTime.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.startTime.Mask = "00:00";
            this.startTime.Name = "startTime";
            this.startTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startTime.Size = new System.Drawing.Size(47, 27);
            this.startTime.TabIndex = 9;
            this.startTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startTime.ValidatingType = typeof(System.DateTime);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(404, 35);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startDateLabel.Size = new System.Drawing.Size(41, 19);
            this.startDateLabel.TabIndex = 7;
            this.startDateLabel.Text = "شروع:";
            // 
            // startDate
            // 
            this.startDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Location = new System.Drawing.Point(281, 32);
            this.startDate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.startDate.Mask = "00/00/0000";
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(88, 27);
            this.startDate.TabIndex = 8;
            this.startDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startDate.ValidatingType = typeof(System.DateTime);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(377, 105);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.titleLabel.Size = new System.Drawing.Size(68, 19);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "توضیحات:";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(41, 144);
            this.description.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.description.Name = "description";
            this.description.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.description.Size = new System.Drawing.Size(400, 27);
            this.description.TabIndex = 14;
            // 
            // selectGroup
            // 
            this.selectGroup.Location = new System.Drawing.Point(41, 190);
            this.selectGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectGroup.Name = "selectGroup";
            this.selectGroup.Size = new System.Drawing.Size(59, 27);
            this.selectGroup.TabIndex = 17;
            this.selectGroup.Text = "انتخاب گروه";
            this.selectGroup.UseVisualStyleBackColor = true;
            this.selectGroup.Visible = false;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(407, 194);
            this.groupLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupLabel.Size = new System.Drawing.Size(38, 19);
            this.groupLabel.TabIndex = 15;
            this.groupLabel.Text = "گروه:";
            this.groupLabel.Visible = false;
            // 
            // group
            // 
            this.group.Location = new System.Drawing.Point(106, 191);
            this.group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group.Name = "group";
            this.group.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.group.Size = new System.Drawing.Size(263, 27);
            this.group.TabIndex = 16;
            this.group.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.group.Visible = false;
            // 
            // addNewWork
            // 
            this.addNewWork.Location = new System.Drawing.Point(357, 250);
            this.addNewWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewWork.Name = "addNewWork";
            this.addNewWork.Size = new System.Drawing.Size(120, 27);
            this.addNewWork.TabIndex = 18;
            this.addNewWork.Text = "ذخیره و جدید";
            this.addNewWork.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 250);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 27);
            this.button1.TabIndex = 19;
            this.button1.Text = "ذخیره و بستن";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 250);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 27);
            this.button2.TabIndex = 20;
            this.button2.Text = "بستن";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 288);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addNewWork);
            this.Controls.Add(this.selectGroup);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.group);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.description);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.startDate);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Work";
            this.Text = "Work";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox endTime;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.MaskedTextBox endDate;
        private System.Windows.Forms.MaskedTextBox startTime;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.MaskedTextBox startDate;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button selectGroup;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.TextBox group;
        private System.Windows.Forms.Button addNewWork;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}