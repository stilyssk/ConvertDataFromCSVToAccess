using ConvertAsset.Models.ModelsForEntityFramework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConvertAsset.Models.ValidateModelsFromCSV
{
   public class ValidateStore_emp: Store_emp
    {
        private ValidateData validateData = new ValidateData();
        

        public void ValidateProductCode(string value)
        {
            ProductCode = validateData.ParseToInt(value);
        }

        public void ValidateInsertedCountFromFirm(string value)
        {
            //value = value.Replace(',','.');
            InsertedCountFromFirm = validateData.ParseToFloat(value);
        }

        public void ValidateAssigment(string value)
        {
            Assigment = validateData.ParseToInt(value);
        }

        public void ValidateDataIncoming(string date, string time)
        {
            DataIncoming = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateDataIncoming(string date)
        {
            DataIncoming = validateData.ParseFromDateTimeToDateTime(date);
        }
    }
}
