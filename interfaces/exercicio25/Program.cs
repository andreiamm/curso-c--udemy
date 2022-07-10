using System;
using System.Collections.Generic;
using System.IO;

namespace exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\nomes.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }

                    list.Sort();
                    foreach (string item in list)
                        Console.WriteLine(item);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
