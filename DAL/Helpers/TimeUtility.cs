using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Text;

namespace DAL.Helpers
{
    public static class TimeUtility
    {
        public static string ToJalali(System.DateTime? date)
        {
            if (!date.HasValue)
            {
                return string.Empty;
            }


            if (date.Value == new DateTime())
            {
                return string.Empty;
            }

            var pc = new PersianCalendar();


            return pc.GetYear(date.Value).ToString("0000") + pc.GetMonth(date.Value).ToString("00") + pc.GetDayOfMonth(date.Value).ToString("00");
        }
 
        public static string FormatFaDate(this string date)
        {
            if (string.IsNullOrWhiteSpace(date))
            {
                return string.Empty;
            }

            return date.Insert(4, "/").Insert(7, "/");
        }
    }
}
