using System;
using System.IO;
using ex01_conjuntos.Entities;

Console.Write("Enter file full path: ");
string path = Console.ReadLine();

HashSet<LogRecord> set = new HashSet<LogRecord>();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] item = sr.ReadLine().Split(' ');
            set.Add(new LogRecord(item[0], DateTime.Parse(item[1])));
        }
        Console.WriteLine($"Total users: {set.Count()}");
    }
}
catch (IOException e)
{
    Console.WriteLine("An error ocurred");
    Console.WriteLine(e.Message);
}

