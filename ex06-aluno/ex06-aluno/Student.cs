namespace ex06_aluno
{
    internal class Student
    {
        public string Name;
        public double Score1;
        public double Score2;
        public double Score3;

        public double CalculateFinalScore()
        {
            return Score1 + Score2 + Score3;
        }

        public bool Passed()
        {
            if (CalculateFinalScore() >= 60.0)
            {
                return true;
            }
            return false;
        }

        public double CalculateMissingScore()
        {
            return 60.0 - CalculateFinalScore();
        }
    }
}
