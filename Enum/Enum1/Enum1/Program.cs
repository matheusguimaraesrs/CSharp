using Enum1.Entities;
using Enum1.Entities.Enums;
using System;


namespace Enum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                HoraPedido = DateTime.Now,
                Status = OrderStatus.PagamentoPendente
            };
            Console.WriteLine(order);
            string txt = OrderStatus.PagamentoPendente.ToString();
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Entregue");
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}