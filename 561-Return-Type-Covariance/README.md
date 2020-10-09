## 서브 타입의 리턴은 공변성을 가져야 한다.
- 설계는 추상에만 의존해야 한다.
- 런타임에서 서브타입은 생성자로 부터 추상이 아닌 구체적인 정보를 입력 받을 수 있다.
- 하지만 리턴의 경우는 어떤가?

## ConsoleApp.First
![](https://drive.google.com/uc?export=download&id=17jQkFuo014H0itXfi4krlg6UcEhKs8jC)
- 리턴 타입과 메소드 파라메터가 구체타입에 의존한다.

## ConsoleApp.Second
- C# 9.0은 리턴타입의 공변성을 제공한다.
- 리턴 타입이 슈퍼타입 보다 구체타입을 반환하는게 오히려 프로그래밍에 유연함을 제공한다. 
```csharp
    internal class MagazineStore : BookStall
    {
        // C# 9.0에서는 정식으로 공변성을 지원한다.
        public override Magazine Sell(IndependentPublisher independentPublisher)
        {
            return new Magazine(independentPublisher);
        }
    }
```