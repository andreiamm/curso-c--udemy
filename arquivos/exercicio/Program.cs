using System.IO;
using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;

string sourcePath = @"c:\temp\originfile.csv";
string targetPath = @"c:\temp\result\finalfile.csv";

try
{
    
    Directory.CreateDirectory(@"c:\temp\result\");
    string[] lines = File.ReadAllLines(sourcePath);

    using (StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (string line in lines)
        {
            string[] item = line.Split(",");
            string product = item[0];
            double price = double.Parse(item[1], CI);
            int quantity = int.Parse(item[2]);

            sw.WriteLine(product + "," + (price * quantity).ToString("F2", CI));
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}