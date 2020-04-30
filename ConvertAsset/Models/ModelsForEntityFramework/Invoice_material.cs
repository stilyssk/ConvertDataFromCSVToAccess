using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertAsset.Models.ModelsForEntityFramework
{
    public class Invoice_material
    {
        public int Invoice { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Frim { get; set; }
        public string Material { get; set; }
        public string MesuarementType { get; set; }
        public float MaterialCount { get; set; }
        public float InsertetIn { get; set; }
        public int Аssignment { get; set; }
        public float Remainder { get; set; }


    }
}
