using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertAsset.Models.ModelsForEntityFramework
{
    public class StorageWork
    {
        public int JobNumber { get; set; }
        public string Store { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public float Quantity { get; set; }
        public string Dimmention { get; set; }
    }
}
