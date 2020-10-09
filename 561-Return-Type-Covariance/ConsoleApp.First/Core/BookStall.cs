using ConsoleApp.Entities;

namespace ConsoleApp.Core
{
    internal class BookStall
    {
        public virtual Book Sell(IndependentPublisher independentPublisher)
        {
            return new Book(independentPublisher);
        }
    }
}
