namespace ConvertAsset
{
    using ConvertAsset.ConvertListToModel;
    using ConvertAsset.Models;
    using ConvertAsset.Models.ModelsForEntityFramework;
    using Repository;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    public class Program
    {

        static void Main(string[] args)
        {
            //string fileName;
            var manipulateCompleteJobs = new ConvertToNot_CompleteJobs_emp();
            var listToComplete_Jobs_Emp_Fin = new ConvertToComplete_jobs_emp_fin();
            var listToCompleteJobsEmp = new ConvertToCompleteJobsEmp();
            var listToAssignSignals = new ConvertToAssignSignals();
            var listToVytr_poluchateli_emp = new ConvertToVytr_poluchateli_emp();
            var listToInvoice_material = new ConvertToInvoice_material();



            var fileList = Directory.GetFiles("./").Where(x => x.Contains(".csv")).ToList();
            foreach (var curentFile in fileList)
            {
                if (curentFile.Contains("Not_CompleteJobs_emp"))
                {
                    //fileName = "Not_CompleteJobs_emp_20200330192726.csv";
                    System.Console.WriteLine(curentFile);

                    var listOfData = manipulateCompleteJobs.Read(curentFile);
                    //var repositoryNot_CompleteJobs_emp = new RepositoryModel<Not_CompleteJobs_emp>(listOfData);

                }
                else
            if (curentFile.Contains("complete_jobs_emp_fin"))
                {
                    //fileName = "complete_jobs_emp_fin_20200330192631.csv";
                    System.Console.WriteLine(curentFile);
                    var listOfData = listToComplete_Jobs_Emp_Fin.Read(curentFile);
                    //var repositoryComplete_Jobs_Emp_Fin = new RepositoryModel<Complete_jobs_emp_fin>(listOfData);
                }
                else if (curentFile.Contains("complete_jobs_emp"))
                {
                    //fileName = "complete_jobs_emp_20200330192505.csv";
                    System.Console.WriteLine(curentFile);
                    var listOfData = listToCompleteJobsEmp.Read(curentFile);
                    //var repositoryCompleteJobsEmp = new RepositoryModel<CompleteJobsEmp>(listOfData);
                }
                if (curentFile.Contains("AssignSignals"))
                {
                    Console.WriteLine(curentFile);
                    var listOfData = listToAssignSignals.Read(curentFile);
                    //var repositoryAssignSignals = new RepositoryModel<AssignSignals>(listOfData);
                }
                if (curentFile.Contains("assets"))
                {
                    //fileName = "assets_20200330192351.csv";
                    System.Console.WriteLine(curentFile);
                    var listToAssets = new ConvertToAssets();
                    var listOfData = listToAssets.Read(curentFile);
                    //var repositoryAssets = new RepositoryModel<Assets>(listOfData);
                }
                if (curentFile.Contains("vytr_poluchateli_emp"))
                {
                    //fileName = "vytr_poluchateli_emp20200330192438.csv";
                    System.Console.WriteLine(curentFile);
                    var listOfData = listToVytr_poluchateli_emp.Read(curentFile);
                    //var repositoryVytr_poluchateli_empList = new RepositoryModel<Vytr_poluchateli_emp>(listOfData);
                }
                if (curentFile.Contains("store_emp"))
                {
                    //fileName = "store_emp_CSV_20200330192448.csv";
                    System.Console.WriteLine(curentFile);
                    var listToStore_emp = new ConvertToStore_emp();
                    var listOfData = listToStore_emp.Read(curentFile);
                    //var repositoryListStore_empList = new RepositoryModel<Store_emp>(listOfData);
                }
                if (curentFile.Contains("invoice_material"))
                {
                    //fileName = "invoice_material_20200331164558.csv";
                    System.Console.WriteLine(curentFile);
                    var listOfData = listToInvoice_material.Read(curentFile);
                    //var repositoryListInvoice_material = new RepositoryModel<Invoice_material>(listOfData);
                }


            }
            var notCompleteJobs = manipulateCompleteJobs.ReadData().Where(x=>x.AwardType =="Профилактика").Where(x=>x.FirmName== "ЕМП – ЮГ").ToList();
            var ttt = new RepositoryModel<Not_CompleteJobs_emp>(notCompleteJobs);

            var listEmpJobs = EMPJobs(listToCompleteJobsEmp.ReadData());
            //var repositoryEmpJobs = new RepositoryModel<EmployeJob>(listEmpJobs);
           
            var listStorageWorks = StorageWorks(listToCompleteJobsEmp.ReadData());
            //var repositoryStorageWorks = new RepositoryModel<StorageWork>(listStorageWorks);



            var allInformation = from CompleteJobsEmp in listToCompleteJobsEmp.ReadData()
                                 join Complete_jobs_emp_fin in listToComplete_Jobs_Emp_Fin.ReadData() on CompleteJobsEmp.JobNumber equals Complete_jobs_emp_fin.JobNumber
                                 join AssignSignals in listToAssignSignals.ReadData() on CompleteJobsEmp.JobNumber equals AssignSignals.SignalNumber
                                 select new CompleteInformation
                                 {
                                     SignalActiv = AssignSignals.SignalActiv,
                                     SignalCAPEX = AssignSignals.SignalCAPEX,
                                     SignalAddress = AssignSignals.SignalAddress,
                                     SignalConnectedJob = AssignSignals.SignalConnectedJob,
                                     SignalConnectWhitInspector = AssignSignals.SignalConnectWhitInspector,
                                     SignalDateFrom = AssignSignals.SignalDateFrom,
                                     SignalDateOfFinnishByContract = AssignSignals.SignalDateOfFinnishByContract,
                                     SignalDateTo = AssignSignals.SignalDateTo,
                                     SignalDateValidateFromCoordinator = AssignSignals.SignalDateValidateFromCoordinator,
                                     SignalDateValidateFromManager = AssignSignals.SignalDateValidateFromManager,
                                     SignalFrim = AssignSignals.SignalFrim,
                                     SignalHour5_5A = AssignSignals.SignalHour5_5A,
                                     SignalHoursDelay = AssignSignals.SignalHoursDelay,
                                     SignalMailFunction = AssignSignals.SignalMailFunction,
                                     SignalNote = AssignSignals.SignalNote,
                                     SignalNumber = AssignSignals.SignalNumber,
                                     SignalPriority = AssignSignals.SignalPriority,
                                     SignalProphylactic = AssignSignals.SignalProphylactic,
                                     SignalRow = AssignSignals.SignalRow,
                                     SignalStartDate = AssignSignals.SignalStartDate,
                                     SignalType = AssignSignals.SignalType,
                                     SignalАtТheЕxpenseОf = AssignSignals.SignalАtТheЕxpenseОf,
                                     JobStartWork = CompleteJobsEmp.JobStartWork,
                                     JobActive = CompleteJobsEmp.JobActive,
                                     JobAddress = CompleteJobsEmp.JobAddress,
                                     JobBaseWork = CompleteJobsEmp.JobBaseWork,
                                     JobCapex = CompleteJobsEmp.JobCapex,
                                     JobCategoryBP = CompleteJobsEmp.JobCategoryBP,
                                     JobConnectedWork = CompleteJobsEmp.JobConnectedWork,
                                     JobFinishWork = CompleteJobsEmp.JobFinishWork,
                                     JobNumber = CompleteJobsEmp.JobNumber,
                                     JobPayFrom = CompleteJobsEmp.JobPayFrom,
                                     JobRazpredelenie = CompleteJobsEmp.JobRazpredelenie,
                                     JobReclamation = CompleteJobsEmp.JobReclamation,
                                     JobTimeForFinishWork = CompleteJobsEmp.JobTimeForFinishWork,
                                     JobTypeOfWork = CompleteJobsEmp.JobTypeOfWork,
                                     JobАction = CompleteJobsEmp.JobАction,
                                     JobNameFirm = CompleteJobsEmp.NameFirm
                                 };

            var repositoryCompleteInformation = new RepositoryModel<CompleteInformation>(allInformation.ToList());

            var testList = listToComplete_Jobs_Emp_Fin.ReadData().Where(x => x.FrimName != string.Empty).Select(x => new { x.FrimName, x.HoursOfTheDinost1 }).ToList();

            //foreach (var obj in testList)
            //{
            //    Console.WriteLine(obj);
            //}


            //Console.ReadKey();


        }

        static List<EmployeJob> EMPJobs(List<CompleteJobsEmp> listCompleteJobsEmp)
        {
            var empJobs = listCompleteJobsEmp;
            var employesJobs = new List<EmployeJob>();
            foreach (var EMPjob in empJobs)
            {
                if (EMPjob.Employ1 != "")
                {
                    employesJobs.Add(new EmployeJob { JobNumber = EMPjob.JobNumber, Employ = EMPjob.Employ1, HourForWork = EMPjob.HourForWork1, DateStartWork = EMPjob.DateStartWork1, DateStopWork = EMPjob.DateStopWork1 });
                }
                if (EMPjob.Employ2 != "")
                {
                    employesJobs.Add(new EmployeJob { JobNumber = EMPjob.JobNumber, Employ = EMPjob.Employ2, HourForWork = EMPjob.HourForWork2, DateStartWork = EMPjob.DateStartWork2, DateStopWork = EMPjob.DateStopWork2 });
                }
                if (EMPjob.Employ3 != "")
                {
                    employesJobs.Add(new EmployeJob { JobNumber = EMPjob.JobNumber, Employ = EMPjob.Employ3, HourForWork = EMPjob.HourForWork3, DateStartWork = EMPjob.DateStartWork3, DateStopWork = EMPjob.DateStopWork3 });
                }
                if (EMPjob.Employ4 != "")
                {
                    employesJobs.Add(new EmployeJob { JobNumber = EMPjob.JobNumber, Employ = EMPjob.Employ4, HourForWork = EMPjob.HourForWork4, DateStartWork = EMPjob.DateStartWork4, DateStopWork = EMPjob.DateStopWork4 });
                }
                if (EMPjob.Employ5 != "")
                {
                    employesJobs.Add(new EmployeJob { JobNumber = EMPjob.JobNumber, Employ = EMPjob.Employ5, HourForWork = EMPjob.HourForWork5, DateStartWork = EMPjob.DateStartWork5, DateStopWork = EMPjob.DateStopWork5 });
                }
                if (EMPjob.Employ6 != "")
                {
                    employesJobs.Add(new EmployeJob { JobNumber = EMPjob.JobNumber, Employ = EMPjob.Employ6, HourForWork = EMPjob.HourForWork6, DateStartWork = EMPjob.DateStartWork6, DateStopWork = EMPjob.DateStopWork6 });
                }
            }
            return employesJobs;
        }

        static List<StorageWork> StorageWorks(List<CompleteJobsEmp> listCompleteJobsEmp)
        {
            var storageWorks = new List<StorageWork>();
            foreach (var storage in listCompleteJobsEmp)
            {
                if (storage.Store1 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store1, Code = storage.Code1, Quantity = storage.Count1, Dimmention = storage.Dimmention1, Name = storage.Name1 });
                }
                if (storage.Store2 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store2, Code = storage.Code2, Quantity = storage.Count2, Dimmention = storage.Dimmention2, Name = storage.Name2 });
                }
                if (storage.Store3 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store3, Code = storage.Code3, Quantity = storage.Count3, Dimmention = storage.Dimmention3, Name = storage.Name3 });
                }
                if (storage.Store4 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store4, Code = storage.Code4, Quantity = storage.Count4, Dimmention = storage.Dimmention4, Name = storage.Name4 });
                }
                if (storage.Store5 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store5, Code = storage.Code5, Quantity = storage.Count5, Dimmention = storage.Dimmention5, Name = storage.Name5 });
                }
                if (storage.Store6 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store6, Code = storage.Code6, Quantity = storage.Count6, Dimmention = storage.Dimmention6, Name = storage.Name6 });
                }
                if (storage.Store7 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store7, Code = storage.Code7, Quantity = storage.Count7, Dimmention = storage.Dimmention7, Name = storage.Name7 });
                }
                if (storage.Store8 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store8, Code = storage.Code8, Quantity = storage.Count8, Dimmention = storage.Dimmention8, Name = storage.Name8 });
                }
                if (storage.Store9 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store9, Code = storage.Code9, Quantity = storage.Count9, Dimmention = storage.Dimmention9, Name = storage.Name9 });
                }
                if (storage.Store1 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store1, Code = storage.Code1, Quantity = storage.Count1, Dimmention = storage.Dimmention1, Name = storage.Name1 });
                }
                if (storage.Store10 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store10, Code = storage.Code10, Quantity = storage.Count10, Dimmention = storage.Dimmention10, Name = storage.Name10 });
                }
                if (storage.Store11 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store11, Code = storage.Code11, Quantity = storage.Count11, Dimmention = storage.Dimmention11, Name = storage.Name11 });
                }
                if (storage.Store12 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store12, Code = storage.Code12, Quantity = storage.Count12, Dimmention = storage.Dimmention12, Name = storage.Name12 });
                }
                if (storage.Store13 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store13, Code = storage.Code13, Quantity = storage.Count13, Dimmention = storage.Dimmention13, Name = storage.Name13 });
                }
                if (storage.Store14 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store14, Code = storage.Code14, Quantity = storage.Count14, Dimmention = storage.Dimmention14, Name = storage.Name14 });
                }
                if (storage.Store15 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store15, Code = storage.Code15, Quantity = storage.Count15, Dimmention = storage.Dimmention15, Name = storage.Name15 });
                }
                if (storage.Store16 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store16, Code = storage.Code16, Quantity = storage.Count16, Dimmention = storage.Dimmention16, Name = storage.Name16 });
                }
                if (storage.Store17 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store17, Code = storage.Code17, Quantity = storage.Count17, Dimmention = storage.Dimmention17, Name = storage.Name17 });
                }
                if (storage.Store18 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store18, Code = storage.Code18, Quantity = storage.Count18, Dimmention = storage.Dimmention18, Name = storage.Name18 });
                }
                if (storage.Store19 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store19, Code = storage.Code19, Quantity = storage.Count19, Dimmention = storage.Dimmention19, Name = storage.Name19 });
                }
                if (storage.Store20 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store20, Code = storage.Code20, Quantity = storage.Count20, Dimmention = storage.Dimmention20, Name = storage.Name20 });
                }
                if (storage.Store21 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store21, Code = storage.Code21, Quantity = storage.Count21, Dimmention = storage.Dimmention21, Name = storage.Name21 });
                }
                if (storage.Store22 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store22, Code = storage.Code22, Quantity = storage.Count22, Dimmention = storage.Dimmention22, Name = storage.Name22 });
                }
                if (storage.Store23 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store23, Code = storage.Code23, Quantity = storage.Count23, Dimmention = storage.Dimmention23, Name = storage.Name23 });
                }
                if (storage.Store24 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store24, Code = storage.Code24, Quantity = storage.Count24, Dimmention = storage.Dimmention24, Name = storage.Name24 });
                }
                if (storage.Store25 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store25, Code = storage.Code25, Quantity = storage.Count25, Dimmention = storage.Dimmention25, Name = storage.Name25 });
                }
                if (storage.Store26 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store26, Code = storage.Code26, Quantity = storage.Count26, Dimmention = storage.Dimmention26, Name = storage.Name26 });
                }
                if (storage.Store27 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store27, Code = storage.Code27, Quantity = storage.Count27, Dimmention = storage.Dimmention27, Name = storage.Name27 });
                }
                if (storage.Store28 != "")
                {
                    storageWorks.Add(new StorageWork { JobNumber = storage.JobNumber, Store = storage.Store28, Code = storage.Code28, Quantity = storage.Count28, Dimmention = storage.Dimmention28, Name = storage.Name28 });
                }
            }

            return storageWorks;
        }
    }
}
