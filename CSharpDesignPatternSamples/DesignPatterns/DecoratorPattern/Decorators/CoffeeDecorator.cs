
using CSharpDesignPatternSamples.DesignPatterns.DecoratorPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.DecoratorPattern.Decorators
{
    /// <summary>
    /// 裝飾器抽象類
    /// </summary>
    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;

        public CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        // 這些方法會呼叫內部被裝飾物件的方法
        public virtual double GetCost()
        {
            return _coffee.GetCost();
        }

        public virtual string GetDescription()
        {
            return _coffee.GetDescription();
        }
    }
}
