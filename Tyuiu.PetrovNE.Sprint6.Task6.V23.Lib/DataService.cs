using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PetrovNE.Sprint6.Task6.V23.Lib
{
    public class DataService : ISprint6Task6V23
    {
        public string CollectTextFromFile(string path)
        {
            string str = "s";
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string mystr = "";
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                       if (line[i] == ' ' || line[i] == '\n')
                        {
                            if (mystr.Contains(str.ToLower()) || mystr.Contains(str.ToUpper()))
                            {
                                resStr += mystr + " ";
                                mystr = "";
                            }
                            mystr = "";
                        }
                       else
                        {
                            mystr += line[i];
                        }
                    }
                }
            }
            return resStr;
        }
    }
}
