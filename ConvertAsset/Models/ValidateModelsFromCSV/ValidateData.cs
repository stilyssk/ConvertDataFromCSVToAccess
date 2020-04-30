using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConvertAsset.Models.ValidateModelsFromCSV
{
    public class ValidateData
    {
        public int ParseToInt(string value)
        {
            if (int.TryParse(value, out int temp))
            {
                return temp;
            }
            else
            {
                return 0;
            }
        }
        public float ParseToFloat(string value)
        {
            //float.TryParse(value,NumberStyles.AllowDecimalPoint, new CultureInfo("bg-BG"), out float ttt);
            if (float.TryParse(value, NumberStyles.AllowDecimalPoint, new CultureInfo("bg-BG"), out float temp))
            {
                return temp;
            }
            else
            {
                return 0f;
            }
        }

        public DateTime ParseFromDateAndTimeToDateTime(string date, string time)
        {
            if (date == "")
            {
                return DateTime.MinValue;
            }
            var dateTimeString = date + " " + time.Substring(0, 5);
            return DateTime.ParseExact(dateTimeString, "dd.MM.yyyy HH:mm", new CultureInfo("bg-BG"));
        }
        public DateTime ParseFromDateTimeToDateTime(string date)
        {
            if (date == "")
            {
                return DateTime.MinValue;
            }
            return DateTime.ParseExact(date, "d.M.yyyy г. HH:mm:ss ч.", new CultureInfo("bg-BG"));
        }
        public DateTime ParseFromDateTimeToDateTimeWhioutLeter(string date)
        {
            if (date == "")
            {
                return DateTime.MinValue;
            }
            return DateTime.ParseExact(date, "d.M.yyyy HH:mm", new CultureInfo("bg-BG"));
        }
        public DateTime ParseFromDateToDateTime(string date)
        {
            if (date == "")
            {
                return DateTime.MinValue;
            }
            return DateTime.ParseExact(date, "dd.MM.yyyy", new CultureInfo("bg-BG"));
        }
        public TimeSpan ParseToHhMm(string time)
        {
            if (time == "")
            {
                return TimeSpan.Zero;
            }
            return TimeSpan.ParseExact(time, "g", new CultureInfo("bg-BG"));
            //return TimeSpan.ParseExact(time, "H:mm", new CultureInfo("bg-BG"));
        }
        public TimeSpan ParseToHhMmChas(string time)
        {
            if (time == "")
            {
                return TimeSpan.Zero;
            }
            time = time.Remove(time.Length - 3, 3);
            return TimeSpan.ParseExact(time, "g", new CultureInfo("bg-BG"));
            //return TimeSpan.ParseExact(time, "H:mm", new CultureInfo("bg-BG"));
        }
    }
}
