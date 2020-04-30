

namespace ConvertAsset.Models.ValidateModelsFromCSV
{
    using ConvertAsset.Models.ModelsForEntityFramework;
    using System;
    using System.Globalization;

    public class ValidateInvoice_material : Invoice_material
    {
        private ValidateData validateData = new ValidateData();

        public void ValidateInvoice(string value)
        {
            Invoice = validateData.ParseToInt(value);
        }

        public void ValidateMaterialCount(string value)
        {
            //value = value.Replace(',', '.');
            MaterialCount = validateData.ParseToFloat(value);
        }
        public void ValidateАssignment(string value)
        {
            Аssignment = validateData.ParseToInt(value);
        }
        public void ValidateRemaindert(string value)
        {
            //value = value.Replace(',', '.');
            Remainder = validateData.ParseToFloat(value);
        }
        public void ValidateInsertetIn(string value)
        {
            //value = value.Replace(',', '.');
            Remainder = validateData.ParseToFloat(value);
        }
        public void ValidateInvoiceDate(string date, string time)
        {
            InvoiceDate = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateInvoiceDate(string date)
        {
            InvoiceDate = validateData.ParseFromDateToDateTime(date);
        }
    }
}
