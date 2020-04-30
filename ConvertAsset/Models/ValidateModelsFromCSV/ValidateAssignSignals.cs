using ConvertAsset.Models.ValidateModelsFromCSV;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConvertAsset.Models
{
    public class ValidateAssignSignals : AssignSignals
    {
        private ValidateData validateData = new ValidateData();

        public void ValidateNumber(string value)
        {
            SignalRow = validateData.ParseToInt(value);
        }

        public void ValidateAssignNumber(string value)
        {
            SignalNumber = validateData.ParseToInt(value);
        }
        
        public void ValidateDateOfOrder(string date, string time)
        {
            SignalStartDate = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateDateOfOrder(string date)
        {
            SignalStartDate = validateData.ParseFromDateToDateTime(date);
        }
        

        public void ValidateDateOfFinnishByContract(string date, string time)
        {
            SignalDateOfFinnishByContract = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateDateOfFinnishByContract(string date)
        {
            SignalDateOfFinnishByContract = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateDateFrom(string date)
        {
            SignalDateFrom = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateDateTo(string date)
        {
            SignalDateTo = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateDateValidateFromCoordinator(string date)
        {
            SignalDateValidateFromCoordinator = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateDateValidateFromManager(string date)
        {
            SignalDateValidateFromManager = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateCountOfHoursDelay(string value)
        {
            SignalHoursDelay = validateData.ParseToInt(value);
        }
        
        public void ValidateHour5_5A(string value)
        {
            SignalHour5_5A = validateData.ParseToHhMmChas(value);
        }

        public void ValidateConnectedJob(string value)
        {
            SignalConnectedJob = validateData.ParseToInt(value);
        }
        
        public void ValidateCAPEX(string value)
        {
            SignalCAPEX = validateData.ParseToInt(value);
        }
        
    }
}
