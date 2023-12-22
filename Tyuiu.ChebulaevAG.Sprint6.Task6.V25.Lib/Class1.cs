using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
using System.Text.RegularExpressions;

namespace Tyuiu.ChebulaevAG.Sprint6.Task6.V25.Lib
{
    public class DataService : ISprint6Task6V25
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line == "")
                    {
                        continue;
                    }
                    else
                    {
                        List<string> result = new List<string>();
                        MatchCollection words = Regex.Matches(line, @"[А-Яа-яA-Za-z]+");
                        foreach (var word in words)
                        {
                            result.Add(word.ToString());
                        }

                        foreach (var word in result)
                        {
                            if (word.Contains("g"))
                            {
                                resStr += word + " ";
                            }
                        }
                    }
                }
            }
            resStr = resStr.Trim();
            return resStr;
        }
    }
}
