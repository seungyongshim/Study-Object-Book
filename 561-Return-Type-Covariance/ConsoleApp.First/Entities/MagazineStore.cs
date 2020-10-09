using ConsoleApp.Core;

namespace ConsoleApp.Entities
{
    internal class MagazineStore : BookStall
    {
        public override Book Sell(IndependentPublisher independentPublisher)
        {
            return new Magazine(independentPublisher);
        }
    }
}
