using ConvertAsset.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertAsset.ConvertListToModel
{
    public class ConvertToComplete_jobs_emp_fin
    {
        private List<Complete_jobs_emp_fin> resultList = new List<Complete_jobs_emp_fin>();

        public List<Complete_jobs_emp_fin> ReadData()
        {
            return resultList;
        }
        private List<Complete_jobs_emp_fin> Load(List<List<string>> InputListString)
        {
            for (int i = 0; i < InputListString.Count; i++)
            {
                var Current = new ValidateComplete_jobs_emp_fin();
                Current.FrimName=(InputListString[i][0]);
                Current.ValidateJobNumber(InputListString[i][1]);
                Current.Address =(InputListString[i][2]);
                Current.Active=InputListString[i][3];
                Current.TypeOfOrder=(InputListString[i][4]);
                Current.PayFrom =   (InputListString[i][5]);
                Current.Reclamation=(InputListString[i][6]);
                Current.ValidateBasicWorkr(InputListString[i][7]);
                Current.Deinost=InputListString[i][8];
                Current.CategoryBP=InputListString[i][9];
                Current.ValidateStartDate(InputListString[i][10], InputListString[i][11]);
                Current.ValidateFinishDate(InputListString[i][12], InputListString[i][13]);
                Current.ValidateLenghtOfTheWork(InputListString[i][14]);
                Current.ValidateJonWork(InputListString[i][15]);
                Current.CAPEX=(InputListString[i][16]);
                Current.Delivered=(InputListString[i][17]);
                Current.Employe1=(InputListString[i][18]);
                Current.ValidateHoursOfTheDinost1(InputListString[i][19]);
                Current.ValidateStartDateEmploye1(InputListString[i][20], InputListString[i][21]);
                Current.ValidateFinishDateEmploye1(InputListString[i][22], InputListString[i][23]);
                Current.Employe2 = (InputListString[i][24]);
                Current.ValidateHoursOfTheDinost2(InputListString[i][25]);
                Current.ValidateStartDateEmploye2(InputListString[i][26], InputListString[i][27]);
                Current.ValidateFinishDateEmploye2(InputListString[i][28], InputListString[i][29]);
                Current.Employe3 = (InputListString[i][30]);
                Current.ValidateHoursOfTheDinost3(InputListString[i][31]);
                Current.ValidateStartDateEmploye3(InputListString[i][32], InputListString[i][33]);
                Current.ValidateFinishDateEmploye3(InputListString[i][34], InputListString[i][35]);
                Current.Employe4 = (InputListString[i][36]);
                Current.ValidateHoursOfTheDinost4(InputListString[i][37]);
                Current.ValidateStartDateEmploye4(InputListString[i][38], InputListString[i][39]);
                Current.ValidateFinishDateEmploye4(InputListString[i][40], InputListString[i][41]);
                Current.Employe5 = (InputListString[i][42]);
                Current.ValidateHoursOfTheDinost5(InputListString[i][43]);
                Current.ValidateStartDateEmploye5(InputListString[i][44], InputListString[i][45]);
                Current.ValidateFinishDateEmploye5(InputListString[i][46], InputListString[i][47]);
                Current.Employe6 = (InputListString[i][48]);
                Current.ValidateHoursOfTheDinost6(InputListString[i][49]);
                Current.ValidateStartDateEmploye6(InputListString[i][50], InputListString[i][51]);
                Current.ValidateFinishDateEmploye6(InputListString[i][52], InputListString[i][53]);
                resultList.Add(Current);
            }
            return resultList;
        }
        public List<Complete_jobs_emp_fin> Read(string filename)
        {
            var assignSignalsList = new List<Complete_jobs_emp_fin>();
            List<List<string>> listOfData;
            var result = new List<Complete_jobs_emp_fin>();
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
