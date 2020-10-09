namespace ConsoleApp.Core
{
    internal class Book
    {
        public Book(Publisher publisher)
        {
            Publisher = publisher;
        }

        protected Publisher Publisher { get; set; }

    }
}
