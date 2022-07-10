using System.IO;

string path = @"c:\temp\file1.txt";

try
{
    /* Tudo que estiver no bloco using será executado e, ao final do bloco,
     * o recurso instanciado será automaticamente fechado. */
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}

