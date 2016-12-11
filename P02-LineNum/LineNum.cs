using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P02_LineNum
{
    class LineNum
    {
        static void Main(string[] args)
        {
            StreamReader reader = File.OpenText("Input.txt");
            StreamWriter writer = File.AppendText("Output.txt");

            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();
                    int lineNumber = 1;
                    while (line != null)
                    {
                        writer.WriteLine($"{lineNumber}. {line}");

                        line = reader.ReadLine();
                        lineNumber++;
                    }

                }
            }
        }
    }
}


