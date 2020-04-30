using ConvertAsset.Models.ModelsForEntityFramework;
using System;
using System.Globalization;

namespace ConvertAsset.Models.ValidateModelsFromCSV
{
   public class ValidateVytr_poluchateli_emp: Vytr_poluchateli_emp
    {
        private ValidateData validateData = new ValidateData();
        

        public void ValidateSignalNumber(string value)
        {
            SignalNumber = validateData.ParseToInt(value);
        }

        public void ValidateDateOfWork(string date, string time)
        {
            DateOfWork = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateDateOfWork(string date)
        {
            DateOfWork = validateData.ParseFromDateToDateTime(date);
        }
    }
}
