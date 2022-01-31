using System;
using System.IO;
using System.Linq;

namespace DataSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"D:\data.txt");
            string str = "";
            foreach (string line in lines)
            {
                int count_space = line.Count(x => x == '|');
                for (int i = 0; i <= count_space; i++)
                {
                    if (i == 0)
                    {
                        str += "('" + line.Split("|")[i].Trim() + "',";
                    }
                    else if (i == count_space)
                    {
                        str += "'" + line.Split("|")[i].Trim() + "'),";
                    }
                    else if (i == 2)
                    {
                        str += "'" + Convert.ToDateTime(line.Split("|")[i]).ToString("yyyy-MM-dd") + "',";
                    }
                    else
                    {
                        str += "'" + line.Split("|")[i].Trim() + "',";
                    }

                }
                str += Environment.NewLine;
            }
            File.WriteAllTextAsync(@"D:\datanew.txt", str);
        }
    }
}
