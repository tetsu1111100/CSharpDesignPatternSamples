
using CSharpDesignPatternSamples.DesignPatterns.FactoryPattern.Interfaces;
using CSharpDesignPatternSamples.DesignPatterns.FactoryPattern.Pizzas;

namespace CSharpDesignPatternSamples.DesignPatterns.FactoryPattern.Factories
{
    /// <summary>
    /// 夏威夷披薩工廠
    /// </summary>
    public class HawaiiPizzaFactory : PizzaFactory
    {
        // 實作工廠方法，建立夏威夷披薩
        public override IPizza CreatePizza()
        {
            return new HawaiiPizza();
        }
    }
}
