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
                int count_space = line.Count(x => x == ' ');
                for(int i=0;i<= count_space;i++)
                {
                    if (i== 0)
                    {
                        str += "('" + line.Split(" ")[i] + "',";
                    }
                    else if(i == count_space)
                    {
                        str += "'" + line.Split(" ")[i] + "'),";
                    }
                    else
                    {
                        str += "'" + line.Split(" ")[i] + "',";
                    }
                    
                }
                str += Environment.NewLine;               
            }
            File.WriteAllTextAsync(@"D:\datanew.txt", str);
        }
    }
}
