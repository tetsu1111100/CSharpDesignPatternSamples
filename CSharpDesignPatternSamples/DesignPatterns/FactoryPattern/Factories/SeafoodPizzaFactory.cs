
using CSharpDesignPatternSamples.DesignPatterns.FactoryPattern.Interfaces;
using CSharpDesignPatternSamples.DesignPatterns.FactoryPattern.Pizzas;

namespace CSharpDesignPatternSamples.DesignPatterns.FactoryPattern.Factories
{
    /// <summary>
    /// 海鮮披薩工廠
    /// </summary>
    public class SeafoodPizzaFactory : PizzaFactory
    {
        // 實作工廠方法，建立海鮮披薩
        public override IPizza CreatePizza()
        {
            return new SeafoodPizza();
        }
    }
}
