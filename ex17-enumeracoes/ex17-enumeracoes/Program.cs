using ex17_enumeracoes.Entities;
using ex17_enumeracoes.Entities.Enums;
using System;

namespace ex17_enumeracoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
        }
    }
}
