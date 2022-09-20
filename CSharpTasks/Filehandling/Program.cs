using System;
using System.IO;
using System.Linq;

namespace Filehandling
{
    class Program
    {
        static void Main(string[] args)
        {
            var path1 = @"C:\010Projects\BMI-Werte.csv";

            for (int i = 18; i <= 100; i++)
            {
                using (FileStream f = new FileStream($@"C:\010Projects\JungeHuepfer_{i}.csv", FileMode.Create));
            }

            for (int i = 18; i < 100; i++)
            {
                using (StreamReader sr = new StreamReader(path1))
                {
                    using (TextWriter tw = File.AppendText($@"C:\010Projects\JungeHuepfer_{i}.csv"))
                    {
                        tw.WriteLine("Geschlecht,Groessee,Alter,Gewicht,Betaetigung,Einordnung");
                        foreach (var line in File.ReadLines(path1).Skip(1))
                        {
                            var replaced = line.Replace(';', ',');
                            var splitted = replaced.Split(',').ToArray();

                            if (Convert.ToInt32(splitted[2]) == i)
                            {
                                tw.WriteLine(replaced);
                            }
                        }
                    }
                }
            }
            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
}
