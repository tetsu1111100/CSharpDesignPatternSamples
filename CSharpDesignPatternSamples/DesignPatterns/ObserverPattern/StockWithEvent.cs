
namespace CSharpDesignPatternSamples.DesignPatterns.ObserverPattern
{
    /// <summary>
    /// 簡化版股價變動事件
    /// </summary>
    internal class StockWithEvent
    {
        //EventHandler<decimal>是 C# 內建的一個泛型委派（Generic Delegate）
        public event EventHandler<decimal> PriceChanged;

        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    PriceChanged?.Invoke(this, _price); // 觸發事件 (通知觀察者 的關鍵一行程式碼) -->傳送當前的StockWithEvent當作sender，_price傳遞最新股價作為eventArgs
                }
            }
        }
    }
}
