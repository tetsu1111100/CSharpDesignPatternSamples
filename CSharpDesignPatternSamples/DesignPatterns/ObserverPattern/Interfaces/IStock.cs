
namespace CSharpDesignPatternSamples.DesignPatterns.ObserverPattern.Interfaces
{
    /// <summary>
    /// 被觀察者介面
    /// </summary>
    public interface IStock
    {
        void Attach(IInvestor investor);
        void Detach(IInvestor investor);
        void Notify();
        decimal Price { get; set; } // 新增一個 Price 屬性來表示股票價格
        string Symbol { get; }
    }
}
