using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConvertAsset
{
    public class ReadCSVFile
    {
        public List<List<string>> Read(string filename)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<List<string>> convertedFromCSV;
            try
            {
                using (StreamReader sr = new StreamReader(filename, Encoding.GetEncoding("windows-1251")))
                {
                    String line = sr.ReadToEnd();
                    ConvertCSVFileToList convertCSVFileToList = new ConvertCSVFileToList();
                    convertedFromCSV = convertCSVFileToList.ConvertAction(line);

                }




            }
            catch (Exception)
            {
                throw;
            }
            return convertedFromCSV;
        }
    }
}
