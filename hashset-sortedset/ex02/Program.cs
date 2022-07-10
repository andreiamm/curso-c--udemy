HashSet<int> set = new HashSet<int> ();
char letter = 'A';

for (int i = 0; i < 3; i++)
{
    Console.Write($"How many students for course {letter}? ");
    int n = int.Parse(Console.ReadLine());

    for (int j = 0; j < n; j++)
    {
        int id = int.Parse(Console.ReadLine());
        set.Add(id);
    }
    letter++;
}

Console.WriteLine($"Total Students: {set.Count()}");