using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConvertAsset
{
    public class AssignSignals
    {
        public int SignalRow { get; set; }
        public string SignalFrim { get; set; }
        public int SignalNumber { get; set; }
        public string SignalConnectWhitInspector{get;set;} // ------new
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


    }
}
