using ConvertAsset.Models.ValidateModelsFromCSV;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConvertAsset.Models
{
    public class ValidateAssets : Assets
    {
        private ValidateData validateData = new ValidateData();

        //public int ParseToInt(string value)
        //{
        //    if (int.TryParse(value, out int temp))
        //    {
        //        return temp;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}

        //public DateTime ParseFromDateAndTimeToDateTime(string date, string time)
        //{
        //    if (date == "")
        //    {
        //        return DateTime.MinValue;
        //    }

        //    var dateTimeString = date + " " + time.Substring(0, 5);
        //    return DateTime.ParseExact(dateTimeString, "dd.MM.yyyy HH:mm", new CultureInfo("bg-BG"));


        //}

        //public DateTime ParseFromDateToDateTime(string date)
        //{
        //    DateTime dateTime;
        //    if (date == "")
        //    {
        //        return DateTime.MinValue;
        //    }
        //    try
        //    {
        //        dateTime= DateTime.ParseExact(date, "dd.MM.yyyy", new CultureInfo("bg-BG"));

        //    }
        //    catch (Exception)
        //    {

        //        dateTime = DateTime.ParseExact(date, "dd.MM.yyyy HH:mm", new CultureInfo("bg-BG"));
        //    }
        //    return dateTime;
        //}

        public void ValidatePegasId(string value)
        {
            PegasId = validateData.ParseToInt(value);
        }
        public void ValidateLevel(string value)
        {
            ActivLevel = validateData.ParseToInt(value);
        }
        public void ValidateDateForCreaton(string date, string time)
        {
            DateForCreaton = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateDateForCreaton(string date)
        {
            DateForCreaton = validateData.ParseFromDateTimeToDateTimeWhioutLeter(date);
        }

        public void ValidateDateForOutFromExploatation(string date, string time)
        {
            DateForOutFromExploatation = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateDateForOutFromExploatation(string date)
        {
            DateForOutFromExploatation = validateData.ParseFromDateTimeToDateTimeWhioutLeter(date);
        }
    }
}
