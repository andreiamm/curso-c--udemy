namespace generics_restrito.Services
{
    internal class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable // restringe aos tipos que podem ser comparados
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list cannot be empty");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                    max = list[i];
            }
            return max;
        }
    }
}
