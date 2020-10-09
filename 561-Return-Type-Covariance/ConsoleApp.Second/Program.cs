using ConsoleApp.Entities;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var customer = new Customer();

            customer.Order(new MagazineStore());
        }
    }
}
