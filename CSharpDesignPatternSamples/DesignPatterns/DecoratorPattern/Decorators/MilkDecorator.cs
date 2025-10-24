
using CSharpDesignPatternSamples.DesignPatterns.DecoratorPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.DecoratorPattern.Decorators
{
    /// <summary>
    /// 具體裝飾器 - 加奶
    /// </summary>
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        public override double GetCost()
        {
            return base.GetCost() + 1.0; // 在基礎價格上加 1 元
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", 加奶"; // 在描述上加上 "加奶"
        }
    }
}
