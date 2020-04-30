using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertAsset.Models.ModelsForEntityFramework
{
    public class Store_emp
    {
        public string Storage { get; set; }
        public DateTime DataIncoming { get; set; }
        public int ProductCode { get; set; }
        public string Name { get; set; }
        public string MesuarementType { get; set; }
        public float InsertedCountFromFirm { get; set; }
        public int Assigment { get; set; }
        public string FirmName { get; set; }

    }
}
