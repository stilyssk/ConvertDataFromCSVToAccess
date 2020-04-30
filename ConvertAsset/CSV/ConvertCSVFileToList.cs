using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConvertAsset
{
    public class ConvertCSVFileToList
    {
        public List<List<string>> ConvertAction(String inputString)
        {

            List<List<string>> resultListList = new List<List<string>>();
            var testInpuList = inputString.Split("\n").ToList();

            for (int i = 0; i < testInpuList.Count; i++)
            {
                List<string> resultList = new List<string>();
                Regex pattern = new Regex(@"\s*(?:""(?<val>[^""]*(""""[^""]*)*)""\s*|(?<val>[^,]*))(?:,|$)", RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
                Match matchResult = pattern.Match(testInpuList[i]);
                while (matchResult.Success)
                {
                    resultList.Add(matchResult.Groups["val"].Value);
                    matchResult = matchResult.NextMatch();
                }
                resultListList.Add(resultList);
            }
            return resultListList;
        }
    }
}
