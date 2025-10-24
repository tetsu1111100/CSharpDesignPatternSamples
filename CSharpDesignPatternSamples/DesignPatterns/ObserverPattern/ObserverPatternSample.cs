
using CSharpDesignPatternSamples.DesignPatterns.ObserverPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.ObserverPattern
{
    internal class ObserverPatternSample
    {
        public void Run1()
        {
            Stock googleStock = new Stock("GOOG");

            // 2. 建立觀察者 (投資者)
            IInvestor investor1 = new Investor("張三");
            IInvestor investor2 = new Investor("李四");

            // 3. 投資者訂閱股票
            googleStock.Attach(investor1);
            googleStock.Attach(investor2);

            // 4. 模擬股價變動
            Console.WriteLine("\n--- 股價變動: 1500 -> 1520 ---\n");
            googleStock.Price = 1500.00m;
            googleStock.Price = 1520.00m;

            // 5. 模擬投資者取消訂閱
            Console.WriteLine("\n--- 李四取消訂閱 ---\n");
            googleStock.Detach(investor2);

            // 6. 模擬股價再次變動
            Console.WriteLine("\n--- 股價再次變動: 1520 -> 1515 ---\n");
            googleStock.Price = 1515.00m;

            Console.ReadKey();
        }

        public void Run2()
        {
            // 訂閱事件
            StockWithEvent googleStock = new StockWithEvent();
            googleStock.PriceChanged += (sender, newPrice) =>
            {
                Console.WriteLine($"事件通知: 股票 GOOG 的最新價格為 {newPrice:C}。");
            };

            // 觸發事件
            googleStock.Price = 1600.00m;
        }
    }
}
