using ConvertAsset.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertAsset.ConvertListToModel
{
    public class ConvertToAssets
    {
        private List<Assets> Load(List<List<string>> InputListString)
        {

            List<Assets> modelList = new List<Assets>();
            for (int i = 0; i < InputListString.Count; i++)
            {
                var Current = new ValidateAssets();
                Current.ValidatePegasId(InputListString[i][0]);
                Current.Name = InputListString[i][1];
                Current.ValidateDateForCreaton(InputListString[i][2]);
                Current.ValidateDateForOutFromExploatation(InputListString[i][3]);
                Current.ReasonForOutFromExploatation = InputListString[i][4];
                Current.Category = InputListString[i][5];
                Current.ValidateLevel(InputListString[i][6]);
                Current.Notes = InputListString[i][7];
                Current.CategoryBP = InputListString[i][8];
                modelList.Add(Current);
            }
            return modelList;
        }
        public List<Assets> Read(string filename)
        {
            List<Assets> assignSignalsList = new List<Assets>();
            List<List<string>> listOfData;
            List<Assets> result = new List<Assets>();
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
