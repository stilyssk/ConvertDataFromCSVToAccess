using ConvertAsset.Models.ModelsForEntityFramework;

namespace ConvertAsset.Models.ValidateModelsFromCSV
{
    public class ValidateNot_CompleteJobs_emp : Not_CompleteJobs_emp
    {
        private ValidateData validateData = new ValidateData();


        

        public void ValidateRowNumber(string value)
        {
            RowNumber = validateData.ParseToInt(value);
        }

        public void ValidateNumberSignal(string value)
        {
            NumberSignal = validateData.ParseToInt(value);
        }

        public void ValidateDateOfAward(string date, string time)
        {
            DateOfAward = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateDateOfAward(string date)
        {
            DateOfAward = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateDateOfContractTermination(string date, string time)
        {
            DateOfContractTermination = validateData.ParseFromDateAndTimeToDateTime(date, time);
        }
        public void ValidateDateOfContractTermination(string date)
        {
            DateOfContractTermination = validateData.ParseFromDateToDateTime(date);
        }

        public void ValidateDaysDelayed(string value)
        {
            DaysDelayed = validateData.ParseToInt(value);
        }
        public void ValidateRelatedWork(string value)
        {
            RelatedWork = validateData.ParseToInt(value);
        }
    }
}
