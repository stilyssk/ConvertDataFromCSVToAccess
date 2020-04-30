using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertAsset.Models.ModelsForEntityFramework
{
    public class EmployeJob
    {
        public int JobNumber { get; set; }
        public string Employ { get; set; }
        public TimeSpan HourForWork { get; set; }
        public DateTime DateStartWork { get; set; }
        public DateTime DateStopWork { get; set; }
    }
}
