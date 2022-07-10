using System.IO;
using System.Collections.Generic;

string path = @"c:\temp\myfolder";

try{
    // Lista todas as subpastas a partir da pasta myfolder.
    /* O 2o argumento (*.*) é uma máscara de busca que sinaliza para procurar qualquer arquivo com qualquer extensão. 
     * O 3o argumento é uma opção de busca. AllDirectories fará com que inclusive as subpastas sejam listadas.
     * O resultado será uma coleção do tipo IEnumerable contendo os strings correspondentes às pastas. */
    IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

    Console.WriteLine("FOLDERS:");
    foreach (string folderName in folders)
    {
        Console.WriteLine(folderName);
    }

    // Lista todos os arquivos a partir da pasta myfolder.
    IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

    Console.WriteLine("FILES:");
    foreach (string fileName in files)
    {
        Console.WriteLine(fileName);
    }

    // Cria uma pasta
    Directory.CreateDirectory(path + "\\newfolder");
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
