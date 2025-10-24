
using CSharpDesignPatternSamples.DesignPatterns.DecoratorPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.DecoratorPattern
{
    public class BlackCoffee : ICoffee
    {
        public double GetCost()
        {
            return 5.0; // 黑咖啡的基礎價格
        }

        public string GetDescription()
        {
            return "黑咖啡";
        }
    }
}
