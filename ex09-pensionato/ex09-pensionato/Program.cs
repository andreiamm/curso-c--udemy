using System;

namespace ex09_pensionato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rooms[] room = new Rooms[10];

            Console.Write("Quantos quartos serão alugados? ");
            int rentedRooms = int.Parse(Console.ReadLine());

            for (int i = 0; i < rentedRooms; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i + 1}:");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int roomNumber = int.Parse(Console.ReadLine());

                room[roomNumber] = new Rooms(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < room.Length; i++)
            {
                if (room[i] != null)
                {
                    Console.WriteLine($"{i}: {room[i]}");
                }
            }
        }
    }
}
