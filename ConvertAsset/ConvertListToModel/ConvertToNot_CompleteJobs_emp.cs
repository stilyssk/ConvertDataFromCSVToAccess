using ConvertAsset.Models;
using ConvertAsset.Models.ModelsForEntityFramework;
using ConvertAsset.Models.ValidateModelsFromCSV;
using System.Collections.Generic;


namespace ConvertAsset.ConvertListToModel
{
    public class ConvertToNot_CompleteJobs_emp 
    {
        private List<Not_CompleteJobs_emp> assignSignalsList = new List<Not_CompleteJobs_emp>();
        public List<Not_CompleteJobs_emp> ReadData()
        {
            return assignSignalsList;
        }


        private List<Not_CompleteJobs_emp> Load(List<List<string>> InputListString)
        {
            var modelList = new List<Not_CompleteJobs_emp> ();
            for (int i = 0; i < InputListString.Count; i++)
            {
                var Current = new ValidateNot_CompleteJobs_emp();
                Current.ValidateRowNumber(InputListString[i][0]);
                Current.FirmName=(InputListString[i][1]);
                Current.Address =(InputListString[i][2]);
                Current.Active=InputListString[i][3];
                Current.ValidateDateOfAward(InputListString[i][4], InputListString[i][5]);
                Current.ValidateDateOfContractTermination(InputListString[i][6]);
                Current.ValidateDaysDelayed(InputListString[i][7]);
                Current.Address=InputListString[i][8];
                Current.Accident=InputListString[i][9];
                Current.AwardType = (InputListString[i][10]);
                Current.Priority =( InputListString[i][11]);
                Current.PayFrom=(InputListString[i][12]);
                Current.Comment=(InputListString[i][13]);
                Current.ValidateRelatedWork(InputListString[i][14]);
                Current.CAPEX=(InputListString[i][15]);
                Current.Status=(InputListString[i][16]);
                Current.PlannedActivity=(InputListString[i][17]);
                Current.EmergencyActivity=(InputListString[i][18]);
                Current.ProphylacticActivity = (InputListString[i][19]);
                

                modelList.Add(Current);
            }
            return modelList;
        }
        public List<Not_CompleteJobs_emp> Read(string inputFilename)
        {
            //var assignSignalsList = new List<Not_CompleteJobs_emp>();
            List<List<string>> listOfData;
            //var result = new List<Not_CompleteJobs_emp>();
            ReadCSVFile readCSVFile = new ReadCSVFile();
            listOfData = readCSVFile.Read(inputFilename);
            listOfData.RemoveAt(0);
            listOfData.RemoveAt(0);
            listOfData.RemoveAt(listOfData.Count - 1);
            assignSignalsList = Load(listOfData);
            return assignSignalsList;
        }
    }
}
