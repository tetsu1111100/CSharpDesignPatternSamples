
using CSharpDesignPatternSamples.DesignPatterns.StatePattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.StatePattern.States
{
    /// <summary>
    /// 具體狀態：製作中
    /// </summary>
    public class MakingState : IState
    {
        private readonly CoffeeMachine _machine;

        public MakingState(CoffeeMachine machine) => _machine = machine;

        public void InsertCoin()
        {
            Console.WriteLine("正在為您準備飲料，請稍候。");
        }

        public void PressButton()
        {
            Console.WriteLine("正在為您準備飲料，請稍候。");
        }

        public void RefundCoin()
        {
            Console.WriteLine("正在為您準備飲料，無法退還硬幣。");
        }
    }
}
