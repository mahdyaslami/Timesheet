using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Makh.Timesheet.TimesheetDataSetTableAdapters;

namespace Makh.Timesheet
{
    /// <summary>
    /// درگاه استفاده از پایگاه داده
    /// </summary>
    /// <remarks>
    /// این کلاس شامل توابعی است که
    /// 1- همه داده هایی که از پایگاه داده می خواهیم را در اختیار ما میگذارد
    /// 2- همه عملیات هایی که می خواهیم روی پایگاه داده انجام دهیم توسط توابع این کلاس انجام خواهد شد
    /// * هرجایی از برنامه که نیاز به پایگاه داده شد باید از طریق این کلاس نیاز ها برآورده بشود
    /// </remarks>
    public class DatabaseProvider
    {
        private static string fileConnectionString;
        private static bool useDefault;

        static DatabaseProvider()
        {
            fileConnectionString = string.Empty;
            useDefault = true;
        }

        /// <summary>
        /// بررسی اینکه امکان اتصال به فایل داده شود توسط لوکال دی بی امکان پذیر است یا خیر
        /// </summary>
        /// <remarks>
        /// این تابع هیچ اکسپشنی پرتاب نمی کنه
        /// خطای اتفاق افتاده رو می تونید از طریق پارامتر ای که اووت تعریف شده دریافت کنید
        /// خطا هایی که خودش بررسی می کند وجود داشتن فایل و درست بودن آدرس است
        /// و خطاهای دیگر مربوط به کانکشن هست
        /// </remarks>
        /// <param name="filename">ادرس فایل پایگاه داده لوکال که قرار است اتصال به آن بررسی شود</param>
        /// <param name="exception">در صورت بروز خطا می تونید خطا رو از این طریق دریاف کنید</param>
        /// <returns>
        /// اگر ترو برگردد اتصال برقرار شده است
        /// اگر فالس برگردد اتصال برقرار نشده خطای اتفاق افتاده را می توان از پارامتر ها گرفت
        /// </returns>
        public static bool TestFileConnection(string filename, out Exception exception)
        {
            exception = null;

            if (string.IsNullOrEmpty(filename))
            {
                exception = new ArgumentNullException(
                    Properties.Resources.FilenameCantBeNullOrEmpty);
                return false;
            }
            else if (File.Exists(filename) == false)
            {
                exception = new FileNotFoundException();
                return false;
            }

            try
            {
                using (SqlConnection connection = 
                    new SqlConnection(CreateFileConnectionString(filename)))
                {
                    connection.Open();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }

            return true;
        }

        /// <summary>
        /// تنظیم کاننکشنی که باید به فایل وصل شود
        /// </summary>
        /// <remarks>
        /// ابتدا تست می کند که اگر ارتباط بر قرار است مقدار فایل کاننکشن استرینگ را ست می کند
        /// و مقدار یوز دیفالت را هم به مقدار فالس تغییر می دهد
        /// </remarks>
        /// <param name="filename">آدرس فایل که قرار است به آن متصل شویم</param>
        public static void SetFileConnectionString(string filename)
        {
            Exception exception = null;
            if (TestFileConnection(filename, out exception))
            {
                fileConnectionString = CreateFileConnectionString(filename);
                useDefault = false;
            }
            else
            {
                throw exception;
            }
        }

        /// <summary>
        /// تنظیمات را برای استفاده از کانکشن پیشفرض فراهم می کند
        /// </summary>
        public static void SetFileConnectionStringToDefault()
        {
            fileConnectionString = string.Empty;
            useDefault = true;
        }

        /// <summary>
        /// کانکشن استرینگ را برای فایل جدید تولید می کند
        /// </summary>
        /// <remarks>با استفاده از الگوی داخل ریسورس و گرفتن ادرس فایل کانکشن استرینگ را درست می کند</remarks>
        /// <returns>کانکشن استرینگ جدید</returns>
        private static string CreateFileConnectionString(string filename)
        {
            return string.Format(
                    Properties.Settings.Default.CustomFileConnectionString,
                    filename);
        }

        /// <summary>
        /// یک دیتاست می گیرد و ویوی هم نامش را پر می کند
        /// </summary>
        /// <remarks>
        /// بررسی می کند که اگر دیتا ست خالی باشد اکسپشن پرتاب کند
        /// اگر دیتا ست پر باشد ولی دیتا تیبل مربوط به این تابع خالی باشد اکسپشن پرتاب می کند
        /// با استفاده از تابع CheckDataSetAndDataTable بررسی ها انجام شود
        /// کاننکت می شود به پایگاه داده و دیتا تیبل خودش را پر می کند
        /// برای مشاهده الگوریتم به عکس "fill data table.png" در پوشه الگوریتم ها مراجعه شود
        /// </remarks>
        /// <param name="dataSet">دیتاستی که می خواهیم پر کنیم</param>
        public static void FillGroupsHierarchyView(TimesheetDataSet dataSet)
        {
            CheckDataSetAndDataTable(dataSet, dataSet.GroupsHierarchyView);

            using (GroupsHierarchyViewTableAdapter adapter =
                new GroupsHierarchyViewTableAdapter())
            {
                SqlConnection conn = GetConnection();
                if (conn != null)
                {
                    adapter.Connection = conn;
                }

                adapter.Fill(dataSet.GroupsHierarchyView);
            }
        }

        /// <summary>
        /// بررسی می کند که پارامتر ها مقدار داشته باشند و در صورت خالی بودن اکسپشن پرتاب می کند
        /// </summary>
        /// <remarks>این تابع برای انسجام داشتن در بررسی کردن ها درون توابع دیگه استفاده شده و بررسی می کنه که اگر پارامتر های ورودیش خالی باشن اکسپشن مناسب پرتاب کنه</remarks>
        /// <param name="dataSet">دیتاستی که می خواهیم بررسی کنیم</param>
        /// <param name="dataTable">دیتاتیبلی که می خواهیم بررسی کنیم</param>
        private static void CheckDataSetAndDataTable(TimesheetDataSet dataSet, DataTable dataTable)
        {
            if (dataSet == null)
                throw new ArgumentNullException("dataSet");
            if (dataTable == null)
                throw new ArgumentNullException("dataTable");
        }


        /// <summary>
        /// دیتا تیبل گروه را با اطلاعات دیتابیس پر می کند
        /// </summary>
        /// <remarks>
        /// دیتاتیبل و دیتاست را با تابع CheckDataSetAndDataTable بررسی می کند
        /// داده ها را از پایگاه داده می گیرد و دیتاتیبل را پر می کند
        /// برای مشاهده الگوریتم به عکس "fill data table.png" در پوشه الگوریتم ها مراجعه شود
        /// </remarks>
        public static void FillGroup(TimesheetDataSet dataSet)
        {
            CheckDataSetAndDataTable(dataSet, dataSet.Group);

            using (GroupTableAdapter adapter =
                new GroupTableAdapter())
            {
                SqlConnection conn = GetConnection();
                if (conn != null)
                {
                    adapter.Connection = conn;
                }

                adapter.Fill(dataSet.Group);
            }
        }

        /// <summary>
        /// بررسی می کند که از چه نوع کاننکشنی برای اتصال به سرور استفاده کند و آن را به آداپتور می دهد
        /// </summary>
        /// <remarks>
        /// یک آداپتور از ورودی میگیرد
        /// بررسی میکند که از اگر باید از کاننکشن پیشفرض استفاده کند که هیچی ولی اگر باید از کاننکشن فایل خاصی استفاده کند آن را به آداپتور نسبت می دهد
        /// </remarks>
        private static SqlConnection GetConnection()
        {
            if (useDefault == false)
            {
                return new SqlConnection(fileConnectionString);
            }
            return null;
        }

        /// <summary>
        /// اطلاعات را ذخیره می کند
        /// </summary>
        /// <remarks>
        /// بررسی می کند دیتا ست نول نباشد
        /// با استفاده از آداپتور منیجر اطلاعات را ذخیره می کند
        /// برای اطلاعات بیشتر به عکس 
        ///  "fill data table.png" در پوشه الگوریتم ها مراجعه شود
        /// </remarks>
        /// <param name="dataSet">دیتا ستی که قرار است تغییرات آن ذخیره شود</param>
        public static void SaveChanges(TimesheetDataSet dataSet)
        {
            if (dataSet == null)
                throw new ArgumentNullException("dataSet");

            using (TableAdapterManager manager = new TableAdapterManager())
            {
                //SqlConnection conn = GetConnection();
                //if (conn == null)
                //{
                //    conn = new SqlConnection(
                //        Properties.Settings.Default.TimesheetConnectionString);
                //    manager.Connection = conn;
                //}
                //else
                //{
                //    manager.Connection = conn;
                //}

                manager.GroupTableAdapter = new GroupTableAdapter();
                //manager.GroupTableAdapter.Connection = conn;

                manager.UserTableAdapter = new UserTableAdapter();
                //manager.UserTableAdapter.Connection = conn;

                manager.WorkTableAdapter = new WorkTableAdapter();
                //manager.WorkTableAdapter.Connection = conn;

                manager.UpdateAll(dataSet);
            }
        }
    }
}
