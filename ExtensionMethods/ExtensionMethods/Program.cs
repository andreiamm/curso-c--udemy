using System;
using ExtensionMethods.Extensions;

DateTime dt = new DateTime(2022, 06, 27, 8, 10, 45);

/* Como o this é apenas uma referência para o 
 * prório objeto, não é necessário passar nenhum
 * parâmetro na chamada do método. */
Console.WriteLine(dt.ElapsedTime());
