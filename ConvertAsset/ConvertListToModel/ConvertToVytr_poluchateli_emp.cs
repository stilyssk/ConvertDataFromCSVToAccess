using ConvertAsset.Models;
using ConvertAsset.Models.ModelsForEntityFramework;
using ConvertAsset.Models.ValidateModelsFromCSV;
using System.Collections.Generic;


namespace ConvertAsset.ConvertListToModel
{
    public class ConvertToVytr_poluchateli_emp
    {
        private List<Vytr_poluchateli_emp> resultList = new List<Vytr_poluchateli_emp>();

        public List<Vytr_poluchateli_emp> ReadData()
        {
            return resultList;
        }
        private List<Vytr_poluchateli_emp> Load(List<List<string>> InputListString)
        {
            for (int i = 0; i < InputListString.Count; i++)
            {
                var Current = new ValidateVytr_poluchateli_emp();
                Current.ValidateSignalNumber(InputListString[i][0]);
                Current.Active=(InputListString[i][1]);
                Current.ValidateDateOfWork(InputListString[i][2]);
                Current.Adress=InputListString[i][3];
                Current.Firm=(InputListString[i][4]);
                Current.NameInspector=(InputListString[i][5]);
                Current.TypeAccident=(InputListString[i][6]);
                Current.Priority=(InputListString[i][7]);
                Current.Material=InputListString[i][8];
                Current.Diameter=InputListString[i][9];                           
                resultList.Add(Current);
            }
            return resultList;
        }
        public List<Vytr_poluchateli_emp> Read(string filename)
        {
            var assignSignalsList = new List<Vytr_poluchateli_emp>();
            List<List<string>> listOfData;
            var result = new List<Vytr_poluchateli_emp>();
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
