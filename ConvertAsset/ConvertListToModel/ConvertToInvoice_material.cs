using ConvertAsset.Models;
using ConvertAsset.Models.ModelsForEntityFramework;
using ConvertAsset.Models.ValidateModelsFromCSV;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertAsset.ConvertListToModel
{
    public class ConvertToInvoice_material
    {
        private  List<Invoice_material> resultList = new List<Invoice_material>();

        public List<Invoice_material> ReadData()
        {
            return resultList;
        }
        private List<Invoice_material> Load(List<List<string>> InputListString)
        {

            for (int i = 0; i < InputListString.Count; i++)
            {
                var Current = new ValidateInvoice_material();
                Current.ValidateInvoice(InputListString[i][0]);
                Current.ValidateInvoiceDate(InputListString[i][1]);
                Current.Frim=(InputListString[i][2]);
                Current.Material=(InputListString[i][3]);
                Current.MesuarementType = InputListString[i][4];
                Current.ValidateMaterialCount(InputListString[i][5]);
                Current.ValidateInsertetIn(InputListString[i][6]);
                Current.ValidateАssignment( InputListString[i][7]);
                Current.ValidateRemaindert( InputListString[i][8]);
                resultList.Add(Current);
            }
            return resultList;
        }
        public List<Invoice_material> Read(string filename)
        {
            var assignSignalsList = new List<Invoice_material>();
            List<List<string>> listOfData;
            var result = new List<Invoice_material>();
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
