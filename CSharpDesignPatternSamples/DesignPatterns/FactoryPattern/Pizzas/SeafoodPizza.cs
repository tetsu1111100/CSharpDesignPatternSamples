
using CSharpDesignPatternSamples.DesignPatterns.FactoryPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.FactoryPattern.Pizzas
{
    /// <summary>
    /// 海鮮披薩
    /// </summary>
    public class SeafoodPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("準備海鮮披薩：放上蝦仁、花枝和起司。");
        }

        public void Bake()
        {
            Console.WriteLine("烘烤海鮮披薩。");
        }

        public void Cut()
        {
            Console.WriteLine("切海鮮披薩。");
        }
    }
}
