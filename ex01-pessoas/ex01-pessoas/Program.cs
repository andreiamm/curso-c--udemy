﻿using System;

namespace ex01_pessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            People p1 = new People();
            People p2 = new People();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.Name = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.Name = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Age = int.Parse(Console.ReadLine());

            if (p1.Age > p2.Age)
            {
                Console.WriteLine($"{p1.Name} é a pessoa mais velha.");
            }
            else
            {
                Console.WriteLine($"{p2.Name} é a pessoa mais velha.");
            }
        }
    }
}
