using ConvertAsset.Models.ModelsForEntityFramework;
using ConvertAsset.Models.ValidateModelsFromCSV;
using System.Collections.Generic;

namespace ConvertAsset.ConvertListToModel
{
    public class ConvertToStore_emp 
    {
        private List<Store_emp> Load(List<List<string>> InputListString)
        {

            List<Store_emp> modelList = new List<Store_emp>();
            for (int i = 0; i < InputListString.Count; i++)
            {
                var Current = new ValidateStore_emp();
                Current.Storage=(InputListString[i][0]);
                Current.ValidateDataIncoming(InputListString[i][1]);
                Current.ValidateProductCode(InputListString[i][2]);
                Current.Name = InputListString[i][3];
                Current.MesuarementType=(InputListString[i][4]);
                Current.ValidateInsertedCountFromFirm( InputListString[i][5]);
                Current.ValidateAssigment(InputListString[i][6]);
                Current.FirmName=(InputListString[i][7]);
                modelList.Add(Current);
            }
            return modelList;
        }
        public List<Store_emp> Read(string filename)
        {
            List<Store_emp> assignSignalsList = new List<Store_emp>();
            List<List<string>> listOfData;
            List<Store_emp> result = new List<Store_emp>();
            ReadCSVFile readCSVFile = new ReadCSVFile();
            listOfData = readCSVFile.Read(filename);
            listOfData.RemoveAt(0);
            listOfData.RemoveAt(0);
            listOfData.RemoveAt(listOfData.Count - 1);
            result = Load(listOfData);
            return result;
        }
    }
}
