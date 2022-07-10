using exercicio2.entities;
using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;

List<Employees> emp = new List<Employees>();

Console.Write("Enter full file path: ");
string path = Console.ReadLine();
Console.Write("Enter salary: ");
double salary = double.Parse(Console.ReadLine(), CI);

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] item = sr.ReadLine().Split(',');

            emp.Add(new Employees(item[0], item[1], double.Parse(item[2], CI)));
        }
    }

    var peopleEmail = emp.Where(e => e.Salary > salary).OrderBy(e => e.Email).Select(e => e.Email);
    Console.WriteLine($"Email of people whose salary is more than {salary.ToString("F2", CI)}:");

    foreach (string email in peopleEmail)
    {
        Console.WriteLine(email);
    }

    var sumSalary = emp.Where(e => e.Name.StartsWith('M')).Sum(e => e.Salary);
    Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sumSalary.ToString("F2", CI)}");
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}
