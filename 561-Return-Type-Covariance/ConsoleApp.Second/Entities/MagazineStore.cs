using ConsoleApp.Core;

namespace ConsoleApp.Entities
{
    internal class MagazineStore : BookStall
    {
        // C# 9.0에서는 정식으로 공변성을 지원한다.
        public override Magazine Sell(IndependentPublisher independentPublisher)
        {
            return new Magazine(independentPublisher);
        }
    }
}
