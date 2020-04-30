using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertAsset.Models.ModelsForEntityFramework
{
    public class Vytr_poluchateli_emp
    {
        public int SignalNumber { get; set; }
        public string Active { get; set; }
        public DateTime DateOfWork { get; set; }
        public string Adress { get; set; }
        public string Firm { get; set; }
        public string NameInspector { get; set; }
        public string TypeAccident { get; set; }
        public string Priority { get; set; }
        public string Material { get; set; }
        public string Diameter { get; set; }
    }
}
