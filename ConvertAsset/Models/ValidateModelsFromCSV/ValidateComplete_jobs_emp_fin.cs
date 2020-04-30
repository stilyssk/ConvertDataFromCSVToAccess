using ConvertAsset.Models.ValidateModelsFromCSV;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConvertAsset.Models
{
    public class ValidateComplete_jobs_emp_fin : Complete_jobs_emp_fin
    {
        private ValidateData validateData = new ValidateData();

        public void ValidateJobNumber(string value)
        {
            JobNumber = validateData.ParseToInt(value);
        }

        public void ValidateBasicWorkr(string value)
        {
            BasicWork = validateData.ParseToInt(value);
        }

        public void ValidateLenghtOfTheWork(string value)
        {
            LenghtOfTheWork = validateData.ParseToHhMm(value);
        }

        public void ValidateJonWork(string value)
        {
            JonWork = validateData.ParseToInt(value);
        }

        public void ValidateHoursOfTheDinost1(string value)
        {
            HoursOfTheDinost1 = validateData.ParseToHhMm(value);
        }

        public void ValidateHoursOfTheDinost2(string value)
        {
            HoursOfTheDinost2 = validateData.ParseToHhMm(value);
        }

        public void ValidateHoursOfTheDinost3(string value)
        {
            HoursOfTheDinost3 = validateData.ParseToHhMm(value);
        }

        public void ValidateHoursOfTheDinost4(string value)
        {
            HoursOfTheDinost4 = validateData.ParseToHhMm(value);
        }

        public void ValidateHoursOfTheDinost5(string value)
        {
            HoursOfTheDinost5 = validateData.ParseToHhMm(value);
        }

        public void ValidateHoursOfTheDinost6(string value)
        {
            HoursOfTheDinost6 = validateData.ParseToHhMm(value);
        }

        public void ValidateStartDate(string date,string time)
        {
            StartDate = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateStartDate(string date)
        {
            StartDate = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateFinishDate(string date, string time)
        {
            FinishDate = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateFinishDate(string date)
        {
            FinishDate = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateStartDateEmploye1(string date, string time)
        {
            StartDateEmploye1 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateStartDateEmploye1(string date)
        {
            StartDateEmploye1 = validateData.ParseFromDateToDateTime(date);
        }


        public void ValidateFinishDateEmploye1(string date, string time)
        {
            FinishDateEmploye1 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateFinishDateEmploye1(string date)
        {
            FinishDateEmploye1 = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateStartDateEmploye2(string date, string time)
        {
            StartDateEmploye1 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateStartDateEmploye2(string date)
        {
            StartDateEmploye1 = validateData.ParseFromDateToDateTime(date);
        }


        public void ValidateFinishDateEmploye2(string date, string time)
        {
            FinishDateEmploye1 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateFinishDateEmploye2(string date)
        {
            FinishDateEmploye1 = validateData.ParseFromDateToDateTime(date);
        }


        public void ValidateStartDateEmploye3(string date, string time)
        {
            StartDateEmploye1 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateStartDateEmploye3(string date)
        {
            StartDateEmploye1 = validateData.ParseFromDateToDateTime(date);
        }


        public void ValidateFinishDateEmploye3(string date, string time)
        {
            FinishDateEmploye1 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateFinishDateEmploye3(string date)
        {
            FinishDateEmploye1 = validateData.ParseFromDateToDateTime(date);
        }


        public void ValidateStartDateEmploye4(string date, string time)
        {
            StartDateEmploye1 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateStartDateEmploye4(string date)
        {
            StartDateEmploye1 = validateData.ParseFromDateToDateTime(date);
        }


        public void ValidateFinishDateEmploye4(string date, string time)
        {
            FinishDateEmploye1 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateFinishDateEmploye4(string date)
        {
            FinishDateEmploye1 = validateData.ParseFromDateToDateTime(date);
        }


        public void ValidateStartDateEmploye5(string date, string time)
        {
            StartDateEmploye1 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateStartDateEmploye5(string date)
        {
            StartDateEmploye1 = validateData.ParseFromDateToDateTime(date);
        }


        public void ValidateFinishDateEmploye5(string date, string time)
        {
            FinishDateEmploye1 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateFinishDateEmploye5(string date)
        {
            FinishDateEmploye1 = validateData.ParseFromDateToDateTime(date);
        }


        public void ValidateStartDateEmploye6(string date, string time)
        {
            StartDateEmploye1 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateStartDateEmploye6(string date)
        {
            StartDateEmploye1 = validateData.ParseFromDateToDateTime(date);
        }


        public void ValidateFinishDateEmploye6(string date, string time)
        {
            FinishDateEmploye1 = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateFinishDateEmploye6(string date)
        {
            FinishDateEmploye1 = validateData.ParseFromDateToDateTime(date);
        }

    }
}

