namespace Makh.Timesheet
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.worksDataGridView = new System.Windows.Forms.DataGridView();
            this.worksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.endDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.startDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.environmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.worksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worksBindingSource)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // worksDataGridView
            // 
            this.worksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.worksDataGridView.Location = new System.Drawing.Point(14, 73);
            this.worksDataGridView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.worksDataGridView.Name = "worksDataGridView";
            this.worksDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.worksDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.worksDataGridView.Size = new System.Drawing.Size(756, 475);
            this.worksDataGridView.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.environmentToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionSettingToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "&Database";
            // 
            // connectionSettingToolStripMenuItem
            // 
            this.connectionSettingToolStripMenuItem.Name = "connectionSettingToolStripMenuItem";
            this.connectionSettingToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.connectionSettingToolStripMenuItem.Text = "Connection &Setting";
            this.connectionSettingToolStripMenuItem.Click += new System.EventHandler(this.connectionSettingToolStripMenuItem_Click);
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(552, 41);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.endDateLabel.Size = new System.Drawing.Size(54, 19);
            this.endDateLabel.TabIndex = 14;
            this.endDateLabel.Text = "تا تاریخ:";
            // 
            // endDateMaskedTextBox
            // 
            this.endDateMaskedTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateMaskedTextBox.Location = new System.Drawing.Point(454, 38);
            this.endDateMaskedTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.endDateMaskedTextBox.Mask = "00/00/0000";
            this.endDateMaskedTextBox.Name = "endDateMaskedTextBox";
            this.endDateMaskedTextBox.Size = new System.Drawing.Size(88, 27);
            this.endDateMaskedTextBox.TabIndex = 15;
            this.endDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(714, 41);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startDateLabel.Size = new System.Drawing.Size(56, 19);
            this.startDateLabel.TabIndex = 12;
            this.startDateLabel.Text = "از تاریخ:";
            // 
            // startDateMaskedTextBox
            // 
            this.startDateMaskedTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateMaskedTextBox.Location = new System.Drawing.Point(616, 38);
            this.startDateMaskedTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.startDateMaskedTextBox.Mask = "00/00/0000";
            this.startDateMaskedTextBox.Name = "startDateMaskedTextBox";
            this.startDateMaskedTextBox.Size = new System.Drawing.Size(88, 27);
            this.startDateMaskedTextBox.TabIndex = 13;
            this.startDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(172, 41);
            this.userLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userLabel.Size = new System.Drawing.Size(38, 19);
            this.userLabel.TabIndex = 16;
            this.userLabel.Text = "کاربر:";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(14, 38);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(150, 27);
            this.userTextBox.TabIndex = 17;
            // 
            // environmentToolStripMenuItem
            // 
            this.environmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupsToolStripMenuItem});
            this.environmentToolStripMenuItem.Name = "environmentToolStripMenuItem";
            this.environmentToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.environmentToolStripMenuItem.Text = "&Environment";
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.groupsToolStripMenuItem.Text = "&Groups";
            this.groupsToolStripMenuItem.Click += new System.EventHandler(this.groupsToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.endDateMaskedTextBox);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.startDateMaskedTextBox);
            this.Controls.Add(this.worksDataGridView);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timesheet";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worksBindingSource)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView worksDataGridView;
        private System.Windows.Forms.BindingSource worksBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.MaskedTextBox endDateMaskedTextBox;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.MaskedTextBox startDateMaskedTextBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.ToolStripMenuItem connectionSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem environmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
    }
}