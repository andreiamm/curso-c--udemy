using System.IO;

string sourcePath = @"c:\temp\file1.txt";   // o uso do @ torna desnecessário o uso de \\ ("c:\\temp\\file1.txt")
string targetPath = @"c:\temp\file2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);  // copia o arquivo de sourcepath para o arquivo de targetPath (se file2.txt não existir)

    string[] lines = File.ReadAllLines(sourcePath); // lê cada linha do arquivo e guarda em uma posição do vetor
    foreach (string line in lines)
        Console.WriteLine(line);
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}