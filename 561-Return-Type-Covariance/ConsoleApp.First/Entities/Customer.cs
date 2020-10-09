using ConsoleApp.Core;

namespace ConsoleApp.Entities
{
    internal class Customer
    {
        private Book Book { get; set; }

        public void Order(BookStall bookStall)
        {
            Book = bookStall.Sell(new IndependentPublisher());
        }
    }
}