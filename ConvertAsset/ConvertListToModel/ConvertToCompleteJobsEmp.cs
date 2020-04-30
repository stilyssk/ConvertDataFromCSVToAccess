using ConvertAsset.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertAsset.ConvertListToModel
{
    public class ConvertToCompleteJobsEmp
    {
        private List<CompleteJobsEmp> resultList = new List<CompleteJobsEmp>();

        public List<CompleteJobsEmp> ReadData()
        {
            return resultList;
        }
        private List<CompleteJobsEmp> Load(List<List<string>> InputListString)
        {
            for (int i = 0; i < InputListString.Count; i++)
            {
                var Current = new ValidateCompleteJobsEmp();
                Current.NameFirm=(InputListString[i][0]);
                Current.ValidateJobNumber(InputListString[i][1]);
                Current.JobAddress =(InputListString[i][2]);
                Current.JobActive=InputListString[i][3];
                Current.JobTypeOfWork=(InputListString[i][4]);
                Current.JobPayFrom =   (InputListString[i][5]);
                Current.JobReclamation=(InputListString[i][6]);
                Current.JobBaseWork=(InputListString[i][7]);
                Current.JobАction=InputListString[i][8];
                Current.JobCategoryBP=InputListString[i][9];
                Current.ValidateStartWork(InputListString[i][10], InputListString[i][11]);
                Current.ValidateFinishWork(InputListString[i][12], InputListString[i][13]);
                Current.ValidateTimeForFinishWorkr(InputListString[i][14]);
                Current.JobConnectedWork=(InputListString[i][15]);
                Current.JobCapex=(InputListString[i][16]);
                Current.JobRazpredelenie=(InputListString[i][17]);
                Current.Store1=(InputListString[i][18]);
                Current.Code1=(InputListString[i][19]);
                Current.Name1=(InputListString[i][20]);
                Current.ValidateCount1(InputListString[i][21]);
                Current.Dimmention1 = (InputListString[i][22]);
                Current.Store2 = (InputListString[i][23]);
                Current.Code2 = (InputListString[i][24]);
                Current.Name2 = (InputListString[i][25]);
                Current.ValidateCount2(InputListString[i][26]);
                Current.Dimmention2 = (InputListString[i][27]);
                Current.Store3 = (InputListString[i][28]);
                Current.Code3 = (InputListString[i][29]);
                Current.Name3 = (InputListString[i][30]);
                Current.ValidateCount3(InputListString[i][31]);
                Current.Dimmention3 = (InputListString[i][32]);
                Current.Store4 = (InputListString[i][33]);
                Current.Code4 = (InputListString[i][34]);
                Current.Name4 = (InputListString[i][35]);
                Current.ValidateCount4(InputListString[i][36]);
                Current.Dimmention4 = (InputListString[i][37]);
                Current.Store5 = (InputListString[i][38]);
                Current.Code5 = (InputListString[i][39]);
                Current.Name5 = (InputListString[i][40]);
                Current.ValidateCount5(InputListString[i][41]);
                Current.Dimmention5 = (InputListString[i][42]);
                Current.Store6 = (InputListString[i][43]);
                Current.Code6 = (InputListString[i][44]);
                Current.Name6 = (InputListString[i][45]);
                Current.ValidateCount6(InputListString[i][46]);
                Current.Dimmention6 = (InputListString[i][47]);
                Current.Store7 = (InputListString[i][48]);
                Current.Code7 = (InputListString[i][49]);
                Current.Name7 = (InputListString[i][50]);
                Current.ValidateCount7(InputListString[i][51]);
                Current.Dimmention7 = (InputListString[i][52]);
                Current.Store8 = (InputListString[i][53]);
                Current.Code8 = (InputListString[i][54]);
                Current.Name8 = (InputListString[i][55]);
                Current.ValidateCount8(InputListString[i][56]);
                Current.Dimmention8 = (InputListString[i][57]);
                Current.Store9 = (InputListString[i][58]);
                Current.Code9 = (InputListString[i][59]);
                Current.Name9 = (InputListString[i][60]);
                Current.ValidateCount9(InputListString[i][61]);
                Current.Dimmention9 = (InputListString[i][62]);
                Current.Store10 = (InputListString[i][63]);
                Current.Code10 = (InputListString[i][64]);
                Current.Name10 = (InputListString[i][65]);
                Current.ValidateCount10(InputListString[i][66]);
                Current.Dimmention10 = (InputListString[i][67]);
                Current.Store11 = (InputListString[i][68]);
                Current.Code11 = (InputListString[i][69]);
                Current.Name11 = (InputListString[i][70]);
                Current.ValidateCount11(InputListString[i][71]);
                Current.Dimmention11 = (InputListString[i][72]);
                Current.Store12 = (InputListString[i][73]);
                Current.Code12 = (InputListString[i][74]);
                Current.Name12 = (InputListString[i][75]);
                Current.ValidateCount12(InputListString[i][76]);
                Current.Dimmention12 = (InputListString[i][77]);
                Current.Store13 = (InputListString[i][78]);
                Current.Code13 = (InputListString[i][79]);
                Current.Name13 = (InputListString[i][80]);
                Current.ValidateCount13(InputListString[i][81]);
                Current.Dimmention13 = (InputListString[i][82]);
                Current.Store14 = (InputListString[i][83]);
                Current.Code14= (InputListString[i][84]);
                Current.Name14 = (InputListString[i][85]);
                Current.ValidateCount14(InputListString[i][86]);
                Current.Dimmention14 = (InputListString[i][87]);
                Current.Store15 = (InputListString[i][88]);
                Current.Code15 = (InputListString[i][89]);
                Current.Name15 = (InputListString[i][90]);
                Current.ValidateCount15(InputListString[i][91]);
                Current.Dimmention15 = (InputListString[i][92]);
                Current.Store16 = (InputListString[i][93]);
                Current.Code16 = (InputListString[i][94]);
                Current.Name16 = (InputListString[i][95]);
                Current.ValidateCount16(InputListString[i][96]);
                Current.Dimmention16 = (InputListString[i][97]);
                Current.Store17 = (InputListString[i][98]);
                Current.Code17 = (InputListString[i][99]);
                Current.Name17 = (InputListString[i][100]);
                Current.ValidateCount17(InputListString[i][101]);
                Current.Dimmention17 = (InputListString[i][102]);
                //-------------------
                Current.Store18 = (InputListString[i][103]);
                Current.Code18 = (InputListString[i][104]);
                Current.Name18 = (InputListString[i][105]);
                Current.ValidateCount18(InputListString[i][106]);
                Current.Dimmention18 = (InputListString[i][107]);

                Current.Store19 = (InputListString[i][108]);
                Current.Code19 = (InputListString[i][109]);
                Current.Name19 = (InputListString[i][110]);
                Current.ValidateCount19(InputListString[i][111]);
                Current.Dimmention19 = (InputListString[i][112]);

                Current.Store20 = (InputListString[i][113]);
                Current.Code20 = (InputListString[i][114]);
                Current.Name20 = (InputListString[i][115]);
                Current.ValidateCount20(InputListString[i][116]);
                Current.Dimmention20 = (InputListString[i][117]);

                Current.Store21 = (InputListString[i][118]);
                Current.Code21 = (InputListString[i][119]);
                Current.Name21 = (InputListString[i][120]);
                Current.ValidateCount21(InputListString[i][121]);
                Current.Dimmention21 = (InputListString[i][122]);

                Current.Store22 = (InputListString[i][123]);
                Current.Code22 = (InputListString[i][124]);
                Current.Name22 = (InputListString[i][125]);
                Current.ValidateCount22(InputListString[i][126]);
                Current.Dimmention22 = (InputListString[i][127]);

                Current.Store23 = (InputListString[i][128]);
                Current.Code23 = (InputListString[i][129]);
                Current.Name23 = (InputListString[i][130]);
                Current.ValidateCount23(InputListString[i][131]);
                Current.Dimmention23 = (InputListString[i][132]);

                Current.Store24 = (InputListString[i][133]);
                Current.Code24 = (InputListString[i][134]);
                Current.Name24 = (InputListString[i][135]);
                Current.ValidateCount24(InputListString[i][136]);
                Current.Dimmention24 = (InputListString[i][137]);

                Current.Store25 = (InputListString[i][138]);
                Current.Code25 = (InputListString[i][139]);
                Current.Name25 = (InputListString[i][140]);
                Current.ValidateCount25(InputListString[i][141]);
                Current.Dimmention25 = (InputListString[i][142]);

                Current.Store26 = (InputListString[i][143]);
                Current.Code26 = (InputListString[i][144]);
                Current.Name26 = (InputListString[i][145]);
                Current.ValidateCount26(InputListString[i][146]);
                Current.Dimmention26 = (InputListString[i][147]);

                Current.Store27 = (InputListString[i][148]);
                Current.Code27 = (InputListString[i][149]);
                Current.Name27 = (InputListString[i][150]);
                Current.ValidateCount27(InputListString[i][151]);
                Current.Dimmention27 = (InputListString[i][152]);

                Current.Store28 = (InputListString[i][153]);
                Current.Code28 = (InputListString[i][154]);
                Current.Name28 = (InputListString[i][155]);
                Current.ValidateCount28(InputListString[i][156]);
                Current.Dimmention28 = (InputListString[i][157]);
                //-------------------

                Current.Employ1=(InputListString[i][158]);
                Current.ValidateHourForWork1(InputListString[i][159]);
                Current.ValidateDateStartWork1(InputListString[i][160], InputListString[i][161]);
                Current.ValidateDateStopWork1(InputListString[i][162], InputListString[i][163]);
                Current.Employ2 = (InputListString[i][164]);
                Current.ValidateHourForWork2(InputListString[i][165]);
                Current.ValidateDateStartWork2(InputListString[i][166], InputListString[i][167]);
                Current.ValidateDateStopWork2(InputListString[i][168], InputListString[i][169]);
                Current.Employ3 = (InputListString[i][170]);
                Current.ValidateHourForWork3(InputListString[i][171]);
                Current.ValidateDateStartWork3(InputListString[i][172], InputListString[i][173]);
                Current.ValidateDateStopWork3(InputListString[i][174], InputListString[i][175]);
                Current.Employ4 = (InputListString[i][176]);
                Current.ValidateHourForWork4(InputListString[i][177]);
                Current.ValidateDateStartWork4(InputListString[i][178], InputListString[i][179]);
                Current.ValidateDateStopWork4(InputListString[i][180], InputListString[i][181]);
                Current.Employ5 = (InputListString[i][182]);
                Current.ValidateHourForWork5(InputListString[i][183]);
                Current.ValidateDateStartWork5(InputListString[i][184], InputListString[i][185]);
                Current.ValidateDateStopWork5(InputListString[i][186], InputListString[i][187]);
                Current.Employ6 = (InputListString[i][188]);
                Current.ValidateHourForWork6(InputListString[i][189]);
                Current.ValidateDateStartWork6(InputListString[i][190], InputListString[i][191]);
                Current.ValidateDateStopWork6(InputListString[i][192], InputListString[i][193]);

                resultList.Add(Current);
            }
            return resultList;
        }
        public List<CompleteJobsEmp> Read(string filename)
        {
            var assignSignalsList = new List<CompleteJobsEmp>();
            List<List<string>> listOfData;
            var result = new List<CompleteJobsEmp>();
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
