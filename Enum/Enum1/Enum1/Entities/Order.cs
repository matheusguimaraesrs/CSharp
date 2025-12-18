using System;
using Enum1.Entities.Enums;

namespace Enum1.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime HoraPedido { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"{Id}, {HoraPedido}, {Status}";
        }
    }
}
