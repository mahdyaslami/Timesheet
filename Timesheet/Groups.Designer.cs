namespace Makh.Timesheet
{
    partial class Groups
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.addTopButton = new System.Windows.Forms.Button();
            this.addBottomButton = new System.Windows.Forms.Button();
            this.addAsChildButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.groupsDataGridView = new System.Windows.Forms.DataGridView();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(296, 6);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(250, 27);
            this.searchTextBox.TabIndex = 22;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(554, 9);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchLabel.Size = new System.Drawing.Size(56, 19);
            this.searchLabel.TabIndex = 21;
            this.searchLabel.Text = "جستجو:";
            // 
            // addTopButton
            // 
            this.addTopButton.Location = new System.Drawing.Point(462, 38);
            this.addTopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTopButton.Name = "addTopButton";
            this.addTopButton.Size = new System.Drawing.Size(150, 27);
            this.addTopButton.TabIndex = 24;
            this.addTopButton.Text = "اضافه کردن در بالا";
            this.addTopButton.UseVisualStyleBackColor = true;
            this.addTopButton.Click += new System.EventHandler(this.addTopButton_Click);
            // 
            // addBottomButton
            // 
            this.addBottomButton.Location = new System.Drawing.Point(306, 38);
            this.addBottomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBottomButton.Name = "addBottomButton";
            this.addBottomButton.Size = new System.Drawing.Size(150, 27);
            this.addBottomButton.TabIndex = 25;
            this.addBottomButton.Text = "اضافه کردن در پایین";
            this.addBottomButton.UseVisualStyleBackColor = true;
            this.addBottomButton.Click += new System.EventHandler(this.addBottomButton_Click);
            // 
            // addAsChildButton
            // 
            this.addAsChildButton.Location = new System.Drawing.Point(150, 38);
            this.addAsChildButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addAsChildButton.Name = "addAsChildButton";
            this.addAsChildButton.Size = new System.Drawing.Size(150, 27);
            this.addAsChildButton.TabIndex = 26;
            this.addAsChildButton.Text = "اضافه کردن زیر مجموعه";
            this.addAsChildButton.UseVisualStyleBackColor = true;
            this.addAsChildButton.Click += new System.EventHandler(this.addAsChildButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(12, 38);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(80, 27);
            this.removeButton.TabIndex = 27;
            this.removeButton.Text = "حذف";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // groupsDataGridView
            // 
            this.groupsDataGridView.AllowUserToAddRows = false;
            this.groupsDataGridView.AllowUserToDeleteRows = false;
            this.groupsDataGridView.AllowUserToResizeRows = false;
            this.groupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.groupsDataGridView.Location = new System.Drawing.Point(12, 71);
            this.groupsDataGridView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupsDataGridView.MultiSelect = false;
            this.groupsDataGridView.Name = "groupsDataGridView";
            this.groupsDataGridView.ReadOnly = true;
            this.groupsDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupsDataGridView.Size = new System.Drawing.Size(600, 357);
            this.groupsDataGridView.TabIndex = 28;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.AllowNew = false;
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.groupsDataGridView);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addAsChildButton);
            this.Controls.Add(this.addBottomButton);
            this.Controls.Add(this.addTopButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Groups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Groups";
            this.Load += new System.EventHandler(this.Groups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button addTopButton;
        private System.Windows.Forms.Button addBottomButton;
        private System.Windows.Forms.Button addAsChildButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.DataGridView groupsDataGridView;
        private System.Windows.Forms.BindingSource groupsBindingSource;
    }
}