using ConvertAsset.Models.ValidateModelsFromCSV;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConvertAsset.Models
{
    public class ValidateCompleteJobsEmp : CompleteJobsEmp
    {
        private ValidateData validateData = new ValidateData();

        public void ValidateJobNumber(string value)
        {
            JobNumber = validateData.ParseToInt(value);
        }

        public void ValidateTimeForFinishWorkr(string value)
        {
            JobTimeForFinishWork = validateData.ParseToHhMm(value);
        }

        public void ValidateCount1(string value)
        {
            Count1 = validateData.ParseToFloat(value);
        }

        public void ValidateCount2(string value)
        {
            Count2 = validateData.ParseToFloat(value);
        }

        public void ValidateCount3(string value)
        {
            Count3 = validateData.ParseToFloat(value);
        }
        public void ValidateCount4(string value)
        {
            Count4 = validateData.ParseToFloat(value);
        }
        public void ValidateCount5(string value)
        {
            Count5 = validateData.ParseToFloat(value);
        }
        public void ValidateCount6(string value)
        {
            Count6 = validateData.ParseToFloat(value);
        }
        public void ValidateCount7(string value)
        {
            Count7 = validateData.ParseToFloat(value);
        }
        public void ValidateCount8(string value)
        {
            Count8 = validateData.ParseToFloat(value);
        }
        public void ValidateCount9(string value)
        {
            Count9 = validateData.ParseToFloat(value);
        }
        public void ValidateCount10(string value)
        {
            Count10 = validateData.ParseToFloat(value);
        }
        public void ValidateCount11(string value)
        {
            Count11 = validateData.ParseToFloat(value);
        }
        public void ValidateCount12(string value)
        {
            Count12 = validateData.ParseToFloat(value);
        }
        public void ValidateCount13(string value)
        {
            Count13 = validateData.ParseToFloat(value);
        }
        public void ValidateCount14(string value)
        {
            Count14 = validateData.ParseToFloat(value);
        }
        public void ValidateCount15(string value)
        {
            Count15 = validateData.ParseToFloat(value);
        }
        public void ValidateCount16(string value)
        {
            Count16 = validateData.ParseToFloat(value);
        }
        public void ValidateCount17(string value)
        {
            Count17 = validateData.ParseToFloat(value);
        }
        //-----------

        public void ValidateCount18(string value)
        {
            Count18 = validateData.ParseToFloat(value);
        }

        public void ValidateCount19(string value)
        {
            Count19 = validateData.ParseToFloat(value);
        }

        public void ValidateCount20(string value)
        {
            Count20 = validateData.ParseToFloat(value);
        }

        public void ValidateCount21(string value)
        {
            Count21 = validateData.ParseToFloat(value);
        }

        public void ValidateCount22(string value)
        {
            Count22 = validateData.ParseToFloat(value);
        }

        public void ValidateCount23(string value)
        {
            Count23 = validateData.ParseToFloat(value);
        }

        public void ValidateCount24(string value)
        {
            Count24 = validateData.ParseToFloat(value);
        }

        public void ValidateCount25(string value)
        {
            Count25 = validateData.ParseToFloat(value);
        }

        public void ValidateCount26(string value)
        {
            Count26 = validateData.ParseToFloat(value);
        }

        public void ValidateCount27(string value)
        {
            Count27 = validateData.ParseToFloat(value);
        }

        public void ValidateCount28(string value)
        {
            Count28 = validateData.ParseToFloat(value);
        }
        //-----------
        public void ValidateHourForWork1(string value)
        {
            HourForWork1 = validateData.ParseToHhMm(value);
        }

        public void ValidateHourForWork2(string value)
        {
            HourForWork2 = validateData.ParseToHhMm(value);
        }

        public void ValidateHourForWork3(string value)
        {
            HourForWork3 = validateData.ParseToHhMm(value);
        }

        public void ValidateHourForWork4(string value)
        {
            HourForWork4 = validateData.ParseToHhMm(value);
        }

        public void ValidateHourForWork5(string value)
        {
            HourForWork5 = validateData.ParseToHhMm(value);
        }

        public void ValidateHourForWork6(string value)
        {
            HourForWork6 = validateData.ParseToHhMm(value);
        }

        public void ValidateStartWork(string date, string time)
        {
            JobStartWork = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateStartWork(string date)
        {
            JobStartWork = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateFinishWork(string date, string time)
        {
            JobFinishWork = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateFinishWork(string date)
        {
            JobFinishWork = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateDateStartWork1(string date, string time)
        {
            DateStartWork1 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateDateStartWork1(string date)
        {
            DateStartWork1 = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateDateStopWork1(string date, string time)
        {
            DateStopWork1 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateDateStopWork1(string date)
        {
            DateStopWork1 = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateDateStartWork2(string date, string time)
        {
            DateStartWork2 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateDateStartWork2(string date)
        {
            DateStartWork2 = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateDateStopWork2(string date, string time)
        {
            DateStopWork2 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateDateStopWork2(string date)
        {
            DateStopWork2 = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateDateStartWork3(string date, string time)
        {
            DateStartWork3 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateDateStartWork3(string date)
        {
            DateStartWork3 = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateDateStopWork3(string date, string time)
        {
            DateStopWork3 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateDateStopWork3(string date)
        {
            DateStopWork3 = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateDateStartWork4(string date, string time)
        {
            DateStartWork4 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateDateStartWork4(string date)
        {
            DateStartWork4 = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateDateStopWork4(string date, string time)
        {
            DateStopWork4 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateDateStopWork4(string date)
        {
            DateStopWork4 = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateDateStartWork5(string date, string time)
        {
            DateStartWork5 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateDateStartWork5(string date)
        {
            DateStartWork5 = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateDateStopWork5(string date, string time)
        {
            DateStopWork5 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateDateStopWork5(string date)
        {
            DateStopWork5 = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateDateStartWork6(string date, string time)
        {
            DateStartWork6 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateDateStartWork6(string date)
        {
            DateStartWork6 = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateDateStopWork6(string date, string time)
        {
            DateStopWork6 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateDateStopWork6(string date)
        {
            DateStopWork6 = validateData.ParseFromDateToDateTime(date);
        }
    }
}
