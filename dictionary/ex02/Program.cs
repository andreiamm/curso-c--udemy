Dictionary<string, int> votes = new Dictionary<string, int>();

Console.Write("Enter file full path: ");
string path = Console.ReadLine();

try
{
    using(StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] item = sr.ReadLine().Split(',');
            string candidate = item[0];
            int numberOfVotes = int.Parse(item[1]);


            if (votes.ContainsKey(candidate)) {
                votes[candidate] += numberOfVotes;
            }
            else
            {
                votes.Add(candidate, numberOfVotes);
                // ou votes[candidate] = numberOfVotes;
            }
        }

        foreach (KeyValuePair<string, int> vote in votes)
        {
            Console.WriteLine(vote.Key + ": " + vote.Value);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}
