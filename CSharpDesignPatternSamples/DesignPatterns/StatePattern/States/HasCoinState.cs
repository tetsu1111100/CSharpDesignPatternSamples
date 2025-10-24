using CSharpDesignPatternSamples.DesignPatterns.StatePattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.StatePattern.States
{
    /// <summary>
    /// 具體狀態：投幣完成
    /// </summary>
    public class HasCoinState : IState
    {
        private readonly CoffeeMachine _machine;

        public HasCoinState(CoffeeMachine machine) => _machine = machine;

        public void InsertCoin()
        {
            Console.WriteLine("你已經投過幣了，請勿重複投幣。");
        }

        public void PressButton()
        {
            Console.WriteLine("正在為您準備飲料，請稍候。");
            _machine.SetState(new MakingState(_machine)); // 改變狀態為 MakingState
        }

        public void RefundCoin()
        {
            Console.WriteLine("退還硬幣。");
            _machine.SetState(new IdleState(_machine)); // 改變狀態為 IdleState
        }
    }
}
