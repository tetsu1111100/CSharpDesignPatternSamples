
using CSharpDesignPatternSamples.DesignPatterns.FactoryPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.FactoryPattern.Pizzas
{
    /// <summary>
    /// 夏威夷披薩
    /// </summary>
    public class HawaiiPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("準備夏威夷披薩：放上火腿、鳳梨和起司。");
        }

        public void Bake()
        {
            Console.WriteLine("烘烤夏威夷披薩。");
        }

        public void Cut()
        {
            Console.WriteLine("切夏威夷披薩。");
        }
    }
}
