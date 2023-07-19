using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ShopApp.Models
{
    public class BaseModel
    {
        #region TimeStamp
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        [Display(Name = "تاریخ ایجاد")]
        [DataType(DataType.DateTime)]
        public string CreatedAtPersian
        {
            get
            {
                string result;
                int day, month, year;
                int hour, minute;
                PersianCalendar persianCalendar = new PersianCalendar();
                day = persianCalendar.GetDayOfMonth((DateTime)CreatedAt);
                month = persianCalendar.GetMonth((DateTime)CreatedAt);
                year = persianCalendar.GetYear((DateTime)CreatedAt);
                hour = persianCalendar.GetHour((DateTime)CreatedAt);
                minute = persianCalendar.GetMinute((DateTime)CreatedAt);
                result = $"{year}/{month}/{day} {hour}:{minute}";
                return result;
            }
        }
        [Display(Name = "تاریخ ویرایش")]
        [Timestamp]
        public DateTime? UpdatedAt { get; set; }
        #endregion
    }
}
