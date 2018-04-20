/*******************************************************************************
 * Author: SPF
 * Description: 扩展方法
*********************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace WisdomScenic.Project.Infrastructure
{
    public static partial class Ext
    {
        /// <summary>
        /// 获取格式化字符串，带时分秒，格式："yyyy-MM-dd HH:mm:ss"
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <param name="isRemoveSecond">是否移除秒</param>
        public static string ToDateTimeString(this DateTime dateTime, bool isRemoveSecond = false)
        {
            if (isRemoveSecond)
                return dateTime.ToString("yyyy-MM-dd HH:mm");
            return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>
        /// 获取格式化字符串，带时分秒，格式："yyyy-MM-dd HH:mm:ss"
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <param name="isRemoveSecond">是否移除秒</param>
        public static string ToDateTimeString(this DateTime? dateTime, bool isRemoveSecond = false)
        {
            if (dateTime == null)
                return string.Empty;
            return ToDateTimeString(dateTime.Value, isRemoveSecond);
        }

        /// <summary>
        /// 获取格式化字符串，不带时分秒，格式："yyyy-MM-dd"
        /// </summary>
        /// <param name="dateTime">日期</param>
        public static string ToDateString(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd");
        }
        /// <summary>
        /// 获取格式化字符串，不带时分秒，格式："yyyy-MM-dd"
        /// </summary>
        /// <param name="dateTime">日期</param>
        public static string ToDateString()
        {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// 获取格式化字符串，不带时分秒，格式："yyyy-MM-dd"
        /// </summary>
        /// <param name="dateTime">日期</param>
        public static string ToDateString(this DateTime? dateTime)
        {
            if (dateTime == null)
                return string.Empty;
            return ToDateString(dateTime.Value);
        }

        /// <summary>
        /// 获取格式化字符串，不带年月日，格式："HH:mm:ss"
        /// </summary>
        /// <param name="dateTime">日期</param>
        public static string ToTimeString(this DateTime dateTime)
        {
            return dateTime.ToString("HH:mm:ss");
        }

        /// <summary>
        /// 获取格式化字符串，不带年月日，格式："HH:mm:ss"
        /// </summary>
        /// <param name="dateTime">日期</param>
        public static string ToTimeString(this DateTime? dateTime)
        {
            if (dateTime == null)
                return string.Empty;
            return ToTimeString(dateTime.Value);
        }

        /// <summary>
        /// 获取格式化字符串，带毫秒，格式："yyyy-MM-dd HH:mm:ss.fff"
        /// </summary>
        /// <param name="dateTime">日期</param>
        public static string ToMillisecondString(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }

        /// <summary>
        /// 获取格式化字符串，带毫秒，格式："yyyy-MM-dd HH:mm:ss.fff"
        /// </summary>
        /// <param name="dateTime">日期</param>
        public static string ToMillisecondString(this DateTime? dateTime)
        {
            if (dateTime == null)
                return string.Empty;
            return ToMillisecondString(dateTime.Value);
        }

        /// <summary>
        /// 获取格式化字符串，不带时分秒，格式："yyyy年MM月dd日"
        /// </summary>
        /// <param name="dateTime">日期</param>
        public static string ToChineseDateString(this DateTime dateTime)
        {
            return string.Format("{0}年{1}月{2}日", dateTime.Year, dateTime.Month, dateTime.Day);
        }

        /// <summary>
        /// 获取格式化字符串，不带时分秒，格式："yyyy年MM月dd日"
        /// </summary>
        /// <param name="dateTime">日期</param>
        public static string ToChineseDateString(this DateTime? dateTime)
        {
            if (dateTime == null)
                return string.Empty;
            return ToChineseDateString(dateTime.SafeValue());
        }

        /// <summary>
        /// 获取格式化字符串，带时分秒，格式："yyyy年MM月dd日 HH时mm分"
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <param name="isRemoveSecond">是否移除秒</param>
        public static string ToChineseDateTimeString(this DateTime dateTime, bool isRemoveSecond = false)
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0}年{1}月{2}日", dateTime.Year, dateTime.Month, dateTime.Day);
            result.AppendFormat(" {0}时{1}分", dateTime.Hour, dateTime.Minute);
            if (isRemoveSecond == false)
                result.AppendFormat("{0}秒", dateTime.Second);
            return result.ToString();
        }

        /// <summary>
        /// 获取格式化字符串，带时分秒，格式："yyyy年MM月dd日 HH时mm分"
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <param name="isRemoveSecond">是否移除秒</param>
        public static string ToChineseDateTimeString(this DateTime? dateTime, bool isRemoveSecond = false)
        {
            if (dateTime == null)
                return string.Empty;
            return ToChineseDateTimeString(dateTime.Value);
        }
        /// <summary>
        /// 将Unix时间戳转换为DateTime类型时间
        /// </summary>
        /// <param name="d">double 型数字</param>
        /// <returns>DateTime</returns>
        public static System.DateTime ConvertIntDateTime(this double d)
        {
            DateTime time = DateTime.MinValue;
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            time = startTime.AddMilliseconds(d);
            return time;
        }
        /// <summary>
        /// 将c# DateTime时间格式转换为Unix时间戳格式
        /// </summary>
        /// <param name="time">时间</param>
        /// <returns>long</returns>
        public static long ConvertDateTimeInt(this DateTime time)
        {
            //double intResult = 0;
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0, 0));
            //intResult = (time- startTime).TotalMilliseconds;
            long t = (time.Ticks - startTime.Ticks) / 10000;            //除10000调整为13位
            return t;
        }

        /// <summary>
        /// 将c# DateTime时间转换星期
        /// </summary>
        /// <param name="time">时间</param>
        /// <returns>星期</returns>
        public static string ConvertDateTimeWeek(this DateTime time)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(time.DayOfWeek);
        }

        /// <summary>
        /// 将数字0,1,2,3,4,5,6转换对应的星期日，一，二，三，四，五，六
        /// </summary> 
        public static string ConvertIntToWeek(this int time)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetDayName((DayOfWeek)time);
        }

        public static DateTime[] ToArryDay(this DateTime starttime, DateTime endtime)
        {
            List<DateTime> dateTime = new List<DateTime>();
            for (DateTime i = starttime; i <= endtime; i = i.AddDays(1))
                dateTime.Add(i);
            return dateTime.ToArray();
        }

        public static DateTime ToDateForHotel(this string timeStr, bool IsStart)
        {
            DateTime dt = DateTime.Parse(DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"));
            timeStr = timeStr ?? "";
            if (timeStr.Length == 16)
            {
                string dateStr = timeStr.Substring(IsStart ? 0 : 8, 8);
                dateStr = dateStr.Substring(0, 4) + "-" + dateStr.Substring(4, 2) + "-" + dateStr.Substring(6, 2);
                bool isSucceed = DateTime.TryParse(dateStr, out dt);
                timeStr = isSucceed ? timeStr : "";
            }
            if (timeStr.Length != 16)
            {
                dt = IsStart ? DateTime.Parse(DateTime.Now.AddDays(1).ToString("yyyy-MM-dd")) : DateTime.Parse(DateTime.Now.AddDays(2).ToString("yyyy-MM-dd"));
            }
            return dt;
        }

        public static string ToMonthEn(this int month)
        {
            string result = string.Empty;
            if (month == 1) result = "Jan.";
            else if (month == 2) result = "Feb.";
            else if (month == 3) result = "Mar.";
            else if (month == 4) result = "Apr.";
            else if (month == 5) result = "May";
            else if (month == 6) result = "June";
            else if (month == 7) result = "July";
            else if (month == 8) result = "Aug.";
            else if (month == 9) result = "Sept.";
            else if (month == 10) result = "Oct.";
            else if (month == 11) result = "Nov.";
            else if (month == 12) result = "Dec.";
            return result;
        }
        public static string TimeInterval(this DateTime value)
        {
            Int32 hour = Int32.Parse(value.ToString("HH"));
            if (hour > 1 && hour < 12) 
            {
                return "早上";
            }
            else if (hour > 11 && hour < 18) 
            {
                return "下午";
            }
            else if (hour > 17 && hour < 2)
            {
                return "晚上";
            }
            else
            {
                return string.Empty;
            }
            
        }
    }
}
