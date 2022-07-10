using generics_reuso;

/************ INTEGERS ***********/
PrintService<int> ps = new PrintService<int>();

Console.Write("How many values? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    ps.AddValue(num);
}

ps.Print();
Console.WriteLine($"First: {ps.First()}");

/************ STRINGS ***********/
PrintService<string> ps2 = new PrintService<string>();

Console.Write("How many people? ");
n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    ps2.AddValue(name);
}

ps2.Print();
Console.WriteLine($"First: {ps2.First()}");