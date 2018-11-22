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
    public partial class Groups : Form
    {
        private TimesheetDataSet timesheetDataSet;

        public Groups()
        {
            InitializeComponent();

            timesheetDataSet = new TimesheetDataSet();
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            GetGroup();
            BindingGroupsDataGridView();
        }

        private void BindingGroupsDataGridView()
        {
            GetGroupsHierarchyView();

            groupsBindingSource.DataSource = timesheetDataSet;
            groupsBindingSource.DataMember = timesheetDataSet
                .GroupsHierarchyView.TableName;
            groupsBindingSource.Filter = string.Empty;
            groupsDataGridView.DataSource = groupsBindingSource;
            
            SetGroupsDataGridViewAppearance();
        }

        /// <summary>
        /// دیتا تیبل ویوی گروه ها به صورت سلسله مراتبی را پر می کند
        /// </summary>
        private void GetGroupsHierarchyView()
        {
            DatabaseProvider.FillGroupsHierarchyView(timesheetDataSet);
        }

        /// <summary>
        /// دیتا تیبل گروه ها را پر می کند
        /// </summary>
        private void GetGroup()
        {
            DatabaseProvider.FillGroup(timesheetDataSet);
        }
        private void SetGroupsDataGridViewAppearance()
        {
            groupsDataGridView
                .Columns[timesheetDataSet.GroupsHierarchyView.IDColumn.ColumnName]
                .Visible = false;

            groupsDataGridView
                .Columns[timesheetDataSet.GroupsHierarchyView.RowNumberColumn.ColumnName]
                .HeaderText = Properties.Resources.RowNumberColumnName;
            groupsDataGridView
                .Columns[timesheetDataSet.GroupsHierarchyView.RowNumberColumn.ColumnName]
                .Width = int.Parse(Properties.Resources.RowNumberColumnWidth);
            groupsDataGridView
                .Columns[timesheetDataSet.GroupsHierarchyView.RowNumberColumn.ColumnName]
                .SortMode = DataGridViewColumnSortMode.NotSortable;

            groupsDataGridView
                .Columns[timesheetDataSet.GroupsHierarchyView.TitleColumn.ColumnName]
                .HeaderText = Properties.Resources.GroupTitleColumnName;
            groupsDataGridView
                .Columns[timesheetDataSet.GroupsHierarchyView.TitleColumn.ColumnName]
                .Width = int.Parse(Properties.Resources.GroupTitleColumnWidth);
            groupsDataGridView
                .Columns[timesheetDataSet.GroupsHierarchyView.TitleColumn.ColumnName]
                .SortMode = DataGridViewColumnSortMode.NotSortable;

            groupsDataGridView
                .Columns[timesheetDataSet.GroupsHierarchyView.HierarchyLevelColumn.ColumnName]
                .Visible = false;

            groupsDataGridView
                .Columns[timesheetDataSet.GroupsHierarchyView.OrderNumberColumn.ColumnName]
                .Visible = false;

            groupsDataGridView
                .Columns[timesheetDataSet.GroupsHierarchyView.ParentIDColumn.ColumnName]
                .Visible = false;

            SetGroupDataGridViewColor();
        }

        /// <summary>
        /// رنگ سطر های گرید گروه ها رابراساس سطحی که دارند تنظیم می کند
        /// </summary>
        private void SetGroupDataGridViewColor()
        {
            int level;
            foreach (DataGridViewRow r in groupsDataGridView.Rows)
            {
                level = int.Parse(r.Cells[
                    timesheetDataSet.GroupsHierarchyView.HierarchyLevelColumn.ColumnName].Value.ToString());
                r.DefaultCellStyle.BackColor =
                    GetHierarchyLevelColor(level);
            }
        }

        /// <summary>
        /// سطح گروه را می گیرد و مقدار رنگ مناسب آن را بر می گرداند
        /// </summary>
        /// <param name="level">سطحی که رنگ آن را می خواهید</param>
        /// <returns>رنگ مناسب برای سطح خواسته شده</returns>
        private Color GetHierarchyLevelColor(int level)
        {
            string result;
            switch (level)
            {
                case 1:
                    result = Properties.Resources.HierarchyLevel01Color;
                    break;
                case 2:
                    result = Properties.Resources.HierarchyLevel02Color;
                    break;
                case 3:
                    result = Properties.Resources.HierarchyLevel03Color;
                    break;
                case 4:
                    result = Properties.Resources.HierarchyLevel04Color;
                    break;
                case 5:
                    result = Properties.Resources.HierarchyLevel05Color;
                    break;
                case 6:
                    result = Properties.Resources.HierarchyLevel06Color;
                    break;
                case 7:
                    result = Properties.Resources.HierarchyLevel07Color;
                    break;
                case 8:
                    result = Properties.Resources.HierarchyLevel08Color;
                    break;
                case 9:
                    result = Properties.Resources.HierarchyLevel09Color;
                    break;
                case 10:
                    result = Properties.Resources.HierarchyLevel10Color;
                    break;
                case 11:
                    result = Properties.Resources.HierarchyLevel11Color;
                    break;
                case 12:
                    result = Properties.Resources.HierarchyLevel12Color;
                    break;
                case 13:
                    result = Properties.Resources.HierarchyLevel13Color;
                    break;
                case 14:
                    result = Properties.Resources.HierarchyLevel14Color;
                    break;
                default: // 15 and bigger than 15
                    result = Properties.Resources.HierarchyLevel15Color;
                    break;
            }
            return System.Drawing.ColorTranslator.FromHtml(result);
        }

        enum AddGroupOption {
            /// <summary>
            /// اضافه کردن گروه در همین سطح در بالای گروه انتخاب شده
            /// </summary>
            AddToTop,
            /// <summary>
            /// اضافه کردن گروه در همین سطح و در پایین گروه انتخاب شده
            /// </summary>
            AddToBottom,
            /// <summary>
            /// اضافه کردن گروه به عنوان فرزنداند گروه انتخاب شده
            /// </summary>
            AddAsChild
        }

        /// <summary>
        /// نام گروه جدید را از کاربر می گیرد و در مکان خواسته شده اضافه می کند
        /// </summary>
        /// <remarks>
        /// بررسی می کند که به بالای گروه متفرقه و به عنوان فرزند گروه متفرقه گروه اضافه نشود
        /// نام را می پرسد و گروه را اضافه می کند.
        /// </remarks>
        /// <param name="addGroupOption">گروه در کجا اضافه شود</param>
        private void AddButtonClick(AddGroupOption addGroupOption)
        {
            NameDialog nameDialog = new NameDialog(
                Properties.Resources.MsgBoxCaption,
                Properties.Resources.PlzTypeGroupName,
                System.Windows.Forms.RightToLeft.Yes,
                ContentAlignment.TopRight,
                Properties.Resources.GroupNameCanntBeEmpty);
            if (nameDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                string name = nameDialog.Input;
                try
                {
                    int id = AddNewGroup(addGroupOption, name);
                    BindingGroupsDataGridView();
                    SelectRowInGroupsDataGridViewByID(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message
                        , Properties.Resources.MsgBoxCaption
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// با توجه به آیدی سطر را در گرید پیدا می کند و آن را انتخاب کردن و اسکرول را جهت نمایش روی آن می برد
        /// </summary>
        /// <remarks>با توجه به آیدی سطر را در گرید پیدا می کند و آن را انتخاب کردن و اسکرول را جهت نمایش روی آن می برد</remarks>
        private void SelectRowInGroupsDataGridViewByID(int id)
        {
            foreach (DataGridViewRow row in groupsDataGridView.Rows)
            {
                if (row
                    .Cells[timesheetDataSet.GroupsHierarchyView.IDColumn.ColumnName]
                    .Value.ToString() == id.ToString())
                {
                    row.Selected = true;
                    groupsDataGridView.FirstDisplayedScrollingRowIndex =
                        row.Index;
                    return;
                }
            }
        }

        /// <summary>
        /// یک گروه جدید اضافه می کند البته با توجه به شیوه اضافه شدن گروه
        /// </summary>
        /// <remarks>
        /// از ورودی نام رو می گیرد و در صورت خالی بودن اکسپشن پرتاب می کند
        /// و با توجه به شیوه اضافه شدن مقادیر مورد نیاز برای اضافه کردن یک گروه را تهیه می کند و با ترتیب مناسب آن را اضافه می کند.
        /// </remarks>
        /// <param name="addGroupOption">شیوه اضافه کردن گروه: 1- در بالای گروه انتخاب شده 2- در پایین گروه انتخاب شده 3- زیر مجموعه گروه انتخاب شده</param>
        /// <param name="title">اسم گروهی که قرار است اضافه شود</param>
        /// <returns>ای دی سطری که اضافه شده است را بر می گرداند</returns>
        private int AddNewGroup(AddGroupOption addGroupOption, string title)
        {
            // 1-1- در صورت خالی بودن نام اکسپشن پرتاب می کند
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException("title");

            // 2-1- در صورتی که بخواهد به فرزندان گروه "متفرقه" و یا بالای آن اضافه کند اکسپشن پرتاب می کند
            if (groupsDataGridView.SelectedRows.Count == 0)
                throw new IndexOutOfRangeException(Properties.Resources.NoRowSelected);
            if (groupsDataGridView.SelectedRows[0]
                .Cells[timesheetDataSet.GroupsHierarchyView.IDColumn.ColumnName]
                .Value.ToString().Equals(Properties.Settings.Default.MotefareqehID.ToString())
                && (addGroupOption == AddGroupOption.AddAsChild || addGroupOption == AddGroupOption.AddToTop))
            {
                throw new OperationCanceledException(Properties.Resources.AddingRestrictionOfMotafareqehGroup);
            }

            // 3- والد گروه را می گیرد
            TimesheetDataSet.GroupRow parent =
                            GetParentRowOfNewItem(addGroupOption);

            // 4- رشته ترتیب را می گیرد
            double orderNumber =
                GetOrderNumberOfNewItem(addGroupOption);

            // 5- گروه را اضافه می کند
            TimesheetDataSet.GroupRow currentRow = timesheetDataSet.Group
                .AddGroupRow(title, parent, parent == null ? string.Empty : parent.ParentSequence, orderNumber);
            DatabaseProvider.SaveChanges(timesheetDataSet);

            // 6- رشته پدران را می گیرد
            string parentSequence =
                GetParentSequenceOfNewItem(addGroupOption, currentRow);
            currentRow.ParentSequence = parentSequence;
            DatabaseProvider.SaveChanges(timesheetDataSet);

            return currentRow.ID;
        }

        /// <summary>
        /// با توجه به سطر انتخاب شده در گرید و با توجه به شیوه اضافه کردن گروه جدید مقدار رشته والدین گروه جدید را بر می گرداند
        /// </summary>
        /// <param name="addGroupOption">شیوه اضافه کردن گروه جدید</param>
        /// <returns>مقدار رشته والدین گروه جدید را بر می گرداند</returns>
        private string GetParentSequenceOfNewItem(AddGroupOption addGroupOption
            , TimesheetDataSet.GroupRow current)
        {
            string separator = Properties.Settings.Default.ParentSequenceSeparator;
            return current.ParentSequence.Trim() + current.ID.ToString() + separator;
        }

        /// <summary>
        /// با توجه به آیتم انتخاب شده در گرید و با توجه به شیوه اضافه کردن رشته ترتیب را بر می گرداند
        /// </summary>
        /// <param name="addGroupOption">شیوه اضافه کردن گروه جدید</param>
        /// <returns>رشته ترتیب را برای سطری که می خواهید اضافه کنید بر می گرداند</returns>
        private double GetOrderNumberOfNewItem(AddGroupOption addGroupOption)
        {
            double min = GetMinimumOrder(addGroupOption);
            double max = GetMaximumOrder(addGroupOption);

            return (max + min) / 2;
        }

        /// <summary>
        /// با توجه به شیوه اضافه کردن یک گروه کران پایین آن را  برای ترتیب بر می گرداند
        /// </summary>
        /// <remarks>
        /// اگر بخواهد به بالا این سطر اضافه کند که ترتیب سطر بالایی می شود کران پایین
        /// اگر بخواهد به پایین این سطر اضافه کند یا به عنوان فرزند بخواهد اضافه کند ابتدا سطری بعدی هم سطح یا سطح پایین تر خود را پیدا می کند سپس ترتیب سطر بالای سطر پیداشده را بر می گرداند
        /// </remarks>
        /// <param name="addGroupOption">شیوه اضافه کردن گروه</param>
        /// <returns>یک عدد اعشاری به عنوان کران پایین</returns>
        private double GetMinimumOrder(AddGroupOption addGroupOption)
        {
            int selectedRowNumber = int.Parse(groupsDataGridView
                .SelectedRows[0].Cells[timesheetDataSet.GroupsHierarchyView
                .RowNumberColumn.ColumnName].Value.ToString());
            int selectedIndex = selectedRowNumber - 1;

            if (addGroupOption == AddGroupOption.AddToTop)
            {
                int preIndex = selectedIndex - 1;

                if (preIndex >= 0)
                {
                    return double.Parse(timesheetDataSet.GroupsHierarchyView
                        .Rows[preIndex]
                        [timesheetDataSet.GroupsHierarchyView.OrderNumberColumn.ColumnName]
                        .ToString());
                }
                else
                {
                    return Properties.Settings.Default.MinimunOrderForGroup;
                }
            }
            else
            {
                int nextIndex = GetNextItemIndexWithSameOrLowerLevel(selectedRowNumber - 1);

                if (nextIndex < 0)
                {
                    return double.Parse(timesheetDataSet.GroupsHierarchyView
                        .Rows[timesheetDataSet.GroupsHierarchyView.Rows.Count - 1]
                        [timesheetDataSet.GroupsHierarchyView.OrderNumberColumn.ColumnName]
                        .ToString());
                }

                return double.Parse(timesheetDataSet.GroupsHierarchyView
                    .Rows[nextIndex - 1]
                    [timesheetDataSet.GroupsHierarchyView.OrderNumberColumn.ColumnName]
                    .ToString());
            }
        }

        /// <summary>
        /// با توجه به مکانی که قرار است گروه اضافه شود مقدار بیشترین ترتیب را بر می گرداند
        /// </summary>
        /// <remarks>
        /// اگر به بالا اضافه کند مقدار بیشترین خودش است
        /// اگر به پایین بخواهد اضافه شود یا به فرزندانش مقدار سطری بعدی ای را برمی گرداند که هم سطح خودش باشد ای از سطح خودش کمتر باشد
        /// در صورتی هم که سطر بعدی وجود نداشته باشد مقدار ماکزیمم را ازتنظیمات برمی گرداند
        /// </remarks>
        /// <param name="addGroupOption">شیوه اضافه کردن گروه جدید</param>
        /// <returns>مقدار بیشترین ترتیب که اعشاری هم هست</returns>
        private double GetMaximumOrder(AddGroupOption addGroupOption)
        {
            int selectedRowNumber = int.Parse(groupsDataGridView
                .SelectedRows[0].Cells[timesheetDataSet.GroupsHierarchyView
                .RowNumberColumn.ColumnName].Value.ToString());
            int selectedIndex = selectedRowNumber - 1;

            if (addGroupOption == AddGroupOption.AddToTop)
            {
                return double.Parse(timesheetDataSet.GroupsHierarchyView.Rows[selectedIndex]
                    [timesheetDataSet.GroupsHierarchyView.OrderNumberColumn.ColumnName]
                    .ToString());
            }
            else
            {
                int nextIndex = GetNextItemIndexWithSameOrLowerLevel(selectedIndex);
                
                if (nextIndex < 0)
                {
                    return Properties.Settings.Default.MaximumOrderForGroup;
                }

                return double.Parse(timesheetDataSet.GroupsHierarchyView.Rows[nextIndex]
                    [timesheetDataSet.GroupsHierarchyView.OrderNumberColumn.ColumnName]
                    .ToString());
            }
        }

        /// <summary>
        /// ایندکس آیتم بعدی هم سطح یا با سطح پایین تر را برمی گرداند
        /// </summary>
        /// <remarks>از سطح جاری به سمت انتها شروع به بررسی می کند ایندکس اولین سطری که هم سطح یا در سطح پایین تر باشد را بر می گرداند در غیر این صورت -1 بر می گرداند</remarks>
        /// <returns>عدد صحیح که ایندکس است در صورت منفی بودن یعنی هیچ ایندکسی پیدا نشده است</returns>
        private int GetNextItemIndexWithSameOrLowerLevel(int selectedIndex)
        {
            if (selectedIndex < 0)
                throw new ArgumentOutOfRangeException("selectedIndex");

            int nextIndex = selectedIndex + 1;
            
            // اگر آخرین سطر باشد
            if (nextIndex > timesheetDataSet.GroupsHierarchyView.Rows.Count)
            {
                return -1;
            }

            int selectedLevel = int.Parse(timesheetDataSet.GroupsHierarchyView.Rows[selectedIndex]
                [timesheetDataSet.GroupsHierarchyView.HierarchyLevelColumn.ColumnName]
                .ToString());

            // اگر یک سطح بالا تر باشد
            for (int nextLevel; nextIndex < timesheetDataSet.GroupsHierarchyView.Rows.Count; nextIndex++)
            {
                nextLevel = int.Parse(timesheetDataSet.GroupsHierarchyView.Rows[nextIndex]
                    [timesheetDataSet.GroupsHierarchyView.HierarchyLevelColumn.ColumnName]
                    .ToString());

                // اگر سطر بعد در گرید یک سطح پایین تر بود یا برابر بود
                if (nextLevel <= selectedLevel)
                {
                    return nextIndex;
                }
            }

            return -1;
        }

        /// <summary>
        /// با توجه به سطر انتخاب شده در گرید و با توجه به شیوه ای که می خواهید گروه اضافه کنید مقدار والد گروهی که قرار است اضافه شود را بر می گرداند
        /// </summary>
        /// <param name="addGroupOption">شیوه اضافه کردن گروه جدید</param>
        /// <returns>سطر والد را از داخل دیتا تیبل بر می گرداند</returns>
        private TimesheetDataSet.GroupRow GetParentRowOfNewItem(AddGroupOption addGroupOption)
        {
            int parentId;
            if (addGroupOption == AddGroupOption.AddAsChild)
            {
                parentId = int.Parse(groupsDataGridView
                    .SelectedRows[0].Cells[timesheetDataSet.GroupsHierarchyView.IDColumn.ColumnName].Value.ToString());
            }
            else
            {
                string parentValue = groupsDataGridView
                    .SelectedRows[0].Cells[timesheetDataSet.GroupsHierarchyView.ParentIDColumn.ColumnName].Value.ToString();
                parentId = string.IsNullOrEmpty(parentValue) ? -1 : int.Parse(parentValue);
            }

            if (parentId > 0)
            {
                return timesheetDataSet.Group.FindByID(parentId);
            }
            return null;
        }

        private void addTopButton_Click(object sender, EventArgs e)
        {
            AddButtonClick(AddGroupOption.AddToTop);
        }

        private void addBottomButton_Click(object sender, EventArgs e)
        {
            AddButtonClick(AddGroupOption.AddToBottom);
        }

        private void addAsChildButton_Click(object sender, EventArgs e)
        {
            AddButtonClick(AddGroupOption.AddAsChild);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            groupsBindingSource.Filter = string
                .Format(Properties.Settings.Default.IsLikeExperssion
                , timesheetDataSet.GroupsHierarchyView.TitleColumn.ColumnName
                , searchTextBox.Text);

            SetGroupDataGridViewColor();
        }
    }
}
