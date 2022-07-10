using System.IO;

string path = @"c:\temp\file1.txt";

StreamReader? sr = null;

try
{
    /* File.OpenText implicitamente instancia o FileStream  
       e instancia o StreamReader em cima dele. */
    sr = File.OpenText(path);

    while (!sr.EndOfStream)  // enquanto não chegar ao fim do arquivo
    {
        /* Armazena 1 linha do arquivo na variável line. */
        string line = sr.ReadLine();
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
finally
{
    if (sr != null) sr.Close();
}
