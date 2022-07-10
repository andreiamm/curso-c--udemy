using ex21_excecoes.Entities;
using ex21_excecoes.Entities.Exceptions;
using System;

namespace ex21_excecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int room = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime cin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime cout = DateTime.Parse(Console.ReadLine());

                Reservation res = new Reservation(room, cin, cout);

                Console.WriteLine("Reservation: " + res);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                cin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                cout = DateTime.Parse(Console.ReadLine());
                res.UpdateDates(cin, cout);
                Console.WriteLine("Reservation: " + res);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e) // Para o caso de se digitar letras no lugar de números.
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e) // Para o caso de haver qualquer outra exceção.
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
