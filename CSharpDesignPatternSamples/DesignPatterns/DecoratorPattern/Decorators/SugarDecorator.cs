
using CSharpDesignPatternSamples.DesignPatterns.DecoratorPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.DecoratorPattern.Decorators
{
    /// <summary>
    /// 具體裝飾器 - 加糖
    /// </summary>
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        public override double GetCost()
        {
            return base.GetCost() + 0.5; // 在基礎價格上加 0.5 元
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", 加糖"; // 在描述上加上 "加糖"
        }
    }
}
