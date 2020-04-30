using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertAsset
{
    public class Assets 
    {
        //Пегас ID,Име,Дата и час на създаване,Дата изв. от експлоатация,Причина изв. от експлоатация,Категория,Ниво,Коментар,Категория БП
        public int PegasId { get; set; }
        public string Name { get; set; }
        public DateTime DateForCreaton { get; set; }
        public DateTime DateForOutFromExploatation { get; set; }
        public string ReasonForOutFromExploatation { get; set; }
        public string Category { get; set; }
        public int ActivLevel { get; set; }
        public string Notes { get; set; }
        public string CategoryBP { get; set; }

    }
}
