using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DatabaseEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                var orderQuery =
                from order in db.Orders.Include(o => o.Customer)
                where order.Freight > 750
                select order;

                foreach (var order in orderQuery) 
                {
                    Console.WriteLine($"{order.Customer.CompanyName} paid {order.Freight} for shipping to {order.ShipCity}");
                }
            }
        }
    }
}
