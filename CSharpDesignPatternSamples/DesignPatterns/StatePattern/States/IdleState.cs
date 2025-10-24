using CSharpDesignPatternSamples.DesignPatterns.StatePattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.StatePattern.States
{
    /// <summary>
    /// 具體狀態：閒置中
    /// </summary>
    public class IdleState : IState
    {
        private readonly CoffeeMachine _machine;

        public IdleState(CoffeeMachine machine) => _machine = machine;

        public void InsertCoin()
        {
            Console.WriteLine("投幣成功，請選擇飲料。");
            _machine.SetState(new HasCoinState(_machine)); // 改變狀態為 HasCoinState
        }

        public void PressButton()
        {
            Console.WriteLine("請先投幣。");
        }

        public void RefundCoin()
        {
            Console.WriteLine("沒有硬幣可以退還。");
        }
    }
}
