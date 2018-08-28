using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventofCode2017
{
    class AdventDay2
    {

        private static List<int[]> ReadFile()
        {
            List<int[]> returnArray = new List<int[]>();
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"e:\workspace\src\github.com\awebbdev\AdventofCode2017\AdventofCode2017\Day2.txt");
            while((line = file.ReadLine()) != null)
            {
                string[] tmp = line.Split('\t');
                int[] tmpArray = Array.ConvertAll(tmp, s => int.Parse(s));
                returnArray.Add(tmpArray);
            }
            file.Close();
            return returnArray;
        }
        private static List<int> GetChecks(List<int[]> input)
        {
            List<int> returnInts = new List<int>();
            foreach(int[] line in input)
            {
                //returnInts.Add(line.Max() - line.Min());
                for (int i = 0; i < line.Length; i++)
                {
                    for (int j = 0; j < line.Length; j++)
                    {
                        if (i == j)
                        {
                            continue;
                        }
                        else if (line[i] % line[j] == 0)
                        {
                            int k = line[i] / line[j];
                            returnInts.Add(k);
                            Console.WriteLine(k);
                            break;
                        }
                    }
                }
            }
            return returnInts;
        }

        private static int CalcCheckSum(List<int> input)
        {
            int i = 0;
            foreach(int j in input)
            {
                i += j;
            }
            return i;
        }
    }
}
