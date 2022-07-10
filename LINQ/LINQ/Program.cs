using System.Linq;

// Specify datasource
int[] numbers = new int[] { 1, 2, 3, 4, 5, };

//Define the query expression
/* Seleciona os números pares na lista e multiplica eles por 10 */
IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

/* Se quisesse salvar o resultado em uma lista teria que ser feita a conversão
 * List<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10).ToList(); */

// Execute the Query
foreach (int number in result)
{
    Console.WriteLine(number);
}
