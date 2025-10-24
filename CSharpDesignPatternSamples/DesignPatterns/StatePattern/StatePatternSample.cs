
namespace CSharpDesignPatternSamples.DesignPatterns.StatePattern
{
    internal class StatePatternSample
    {
        public void Run()
        {
            CoffeeMachine machine = new CoffeeMachine();

            Console.WriteLine("--- 測試流程一：正常操作 ---");
            machine.InsertCoin();
            machine.PressButton();
            machine.RefundCoin(); // 處於 Making 狀態，無法退幣

            Console.WriteLine("\n--- 測試流程二：投幣後退幣 ---");
            machine.InsertCoin();
            machine.RefundCoin();

            Console.ReadKey();
        }
    }
}
