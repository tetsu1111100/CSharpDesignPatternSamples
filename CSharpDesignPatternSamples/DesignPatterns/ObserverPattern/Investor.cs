
using CSharpDesignPatternSamples.DesignPatterns.ObserverPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.ObserverPattern
{
    internal class Investor : IInvestor
    {
        public string Name { get; }

        public Investor(string name)
        {
            Name = name;
        }

        // 當被通知時，印出最新的股價
        public void Update(IStock stock)
        {
            Console.WriteLine($"通知 {Name}: 股票 {stock.Symbol} 的最新價格為 {stock.Price:C}。");
        }
    }
}
