using System.IO;

string path = @"c:\temp\myfolder\file1.txt";

Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
Console.WriteLine("GetFileName: " + Path.GetFileName(path));
Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
Console.WriteLine("GetExtension: " + Path.GetExtension(path));
Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
/* Retorna a pasta temporária do sistema */
Console.WriteLine("GetTempPath: " + Path.GetTempPath());
/* Retorna qual é o caractere de separação de pastas */
Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
/* Retorna qual é o caractere de separação de caminhos */
Console.WriteLine("PathSeparator: " + Path.PathSeparator);
