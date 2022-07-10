using System.IO;

string path = @"c:\temp\file1.txt";

/* Stream genérica, que não faz nenhum tratamento especial para acessar um recurso de entrada e saída. */
FileStream fs = null;

/* Stream particular otimizada para a função desejada. */
StreamReader sr = null;

try
{
    /* Instancia o fs associado a um arquivo com a finalidade de abri-lo para acesso. */
    fs = new FileStream(path, FileMode.Open);

    sr = new StreamReader(fs);

    /* Armazena 1 linha do arquivo na variável line. */
    string line = sr.ReadLine();

    Console.WriteLine(line);
}
catch(IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
finally
{
    if (sr != null) sr.Close();
    if (fs != null) fs.Close();
}
