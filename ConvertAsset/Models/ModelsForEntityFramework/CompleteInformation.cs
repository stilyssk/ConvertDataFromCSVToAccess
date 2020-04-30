using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertAsset.Models.ModelsForEntityFramework
{
    public class CompleteInformation
    {
        public int SignalRow { get; set; }
        public string SignalFrim { get; set; }
        public int SignalNumber { get; set; }
        public string SignalConnectWhitInspector { get; set; } // ------new
        public string SignalActiv { get; set; }
        public DateTime SignalStartDate { get; set; }
        public DateTime SignalDateOfFinnishByContract { get; set; }
        public int SignalHoursDelay { get; set; }
        public string SignalAddress { get; set; }
        public string SignalMailFunction { get; set; }
        public string SignalType { get; set; }
        public string SignalPriority { get; set; }
        public TimeSpan SignalHour5_5A { get; set; }
        public DateTime SignalDateFrom { get; set; } // new
        public DateTime SignalDateTo { get; set; } // new 
        public string SignalProphylactic { get; set; }  //new 
        public string SignalNote { get; set; } // new 
        public DateTime SignalDateValidateFromCoordinator { get; set; } //new
        public DateTime SignalDateValidateFromManager { get; set; } // new
        public string SignalАtТheЕxpenseОf { get; set; }
        public int SignalConnectedJob { get; set; }
        public int SignalCAPEX { get; set; }

        public string JobNameFirm { get; set; }
        public int JobNumber { get; set; }
        public string JobAddress { get; set; }
        public string JobActive { get; set; }
        public string JobTypeOfWork { get; set; }
        public string JobPayFrom { get; set; }
        public string JobReclamation { get; set; }
        public string JobBaseWork { get; set; }
        public string JobАction { get; set; }
        public string JobCategoryBP { get; set; }
        public DateTime JobStartWork { get; set; }
        public DateTime JobFinishWork { get; set; }
        public TimeSpan JobTimeForFinishWork { get; set; }
        public string JobConnectedWork { get; set; }
        public string JobCapex { get; set; }
        public string JobRazpredelenie { get; set; } //-------
    }
}
