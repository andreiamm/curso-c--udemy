using System;
using ex17_enumeracoes.Entities.Enums;

namespace ex17_enumeracoes.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                   + ", "
                   + Moment
                   + ", "
                   + Status;
        }
    }
}
