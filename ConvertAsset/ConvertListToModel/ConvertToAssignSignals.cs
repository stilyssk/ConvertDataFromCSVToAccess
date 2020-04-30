using ConvertAsset.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertAsset.ConvertListToModel
{
    public class ConvertToAssignSignals
    {
        private List<AssignSignals> resultList = new List<AssignSignals>();

        public List<AssignSignals> ReadData()
        {
            return resultList;
        }
        private List<AssignSignals> Load(List<List<string>> InputListString)
        {
            for (int i = 0; i < InputListString.Count; i++)
            {
                var Current = new ValidateAssignSignals();
                Current.ValidateNumber(InputListString[i][0]);
                Current.SignalFrim = InputListString[i][1];
                Current.ValidateAssignNumber(InputListString[i][2]);
                Current.SignalConnectWhitInspector = InputListString[i][3];
                Current.SignalActiv= InputListString[i][4];
                Current.ValidateDateOfOrder(InputListString[i][5], InputListString[i][6]);
                Current.ValidateDateOfFinnishByContract(InputListString[i][7]);
                Current.ValidateCountOfHoursDelay(InputListString[i][8]);
                Current.SignalAddress=InputListString[i][9];
                Current.SignalMailFunction=InputListString[i][10];
                Current.SignalType=InputListString[i][11];
                Current.SignalPriority=InputListString[i][12];
                Current.ValidateHour5_5A(InputListString[i][13]);
                Current.ValidateDateFrom(InputListString[i][14]);
                Current.ValidateDateTo(InputListString[i][15]);
                Current.SignalProphylactic = InputListString[i][16];
                Current.SignalNote = InputListString[i][17];
                Current.ValidateDateValidateFromCoordinator(InputListString[i][18]);
                Current.ValidateDateValidateFromManager(InputListString[i][19]);
                Current.SignalАtТheЕxpenseОf=InputListString[i][20];
                Current.ValidateConnectedJob(InputListString[i][21]);
                Current.ValidateCAPEX(InputListString[i][22]);

                resultList.Add(Current);
            }
            return resultList;
        }
        public List<AssignSignals> Read(string filename)
        {
            var assignSignalsList = new List<AssignSignals>();
            List<List<string>> listOfData;
            var result = new List<AssignSignals>();
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
