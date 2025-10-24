
using CSharpDesignPatternSamples.DesignPatterns.ObserverPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.ObserverPattern
{
    internal class Stock : IStock
    {
        private List<IInvestor> _investors = new List<IInvestor>();

        private decimal _price;

        public string Symbol { get; }

        public Stock(string symbol)
        {
            Symbol = symbol;
        }

        // 當股價改變時，通知所有觀察者
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify(); // 股價改變時，呼叫 Notify()
                }
            }
        }

        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
            Console.WriteLine($"投資者 {investor} 已訂閱 {Symbol} 股票。");
        }

        public void Detach(IInvestor investor)
        {
            _investors.Remove(investor);
            Console.WriteLine($"投資者 {investor} 已取消訂閱 {Symbol} 股票。");
        }

        public void Notify()
        {
            // 遍歷所有觀察者，並呼叫他們的 Update 方法
            foreach (var investor in _investors)
            {
                investor.Update(this);
            }
        }
    }
}
