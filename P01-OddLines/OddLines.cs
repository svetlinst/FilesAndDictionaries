//Write a program that reads a text file and writes its every odd line in another file. Line numbers starts from 0. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


    public class OddLines
    {
        public static void Main()
        {
        StreamReader reader = File.OpenText("input.txt");
        StreamWriter writer = File.AppendText("Output.txt");

        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();
                int counter = 0;
                while (line != null)
                {
                    if (counter % 2 != 0)
                    {
                        writer.WriteLine(line);

                    }
                    counter++;
                    line = reader.ReadLine();
                }
            }
        }

        }
    }

