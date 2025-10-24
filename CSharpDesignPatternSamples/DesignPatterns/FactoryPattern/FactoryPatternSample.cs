
using CSharpDesignPatternSamples.DesignPatterns.FactoryPattern.Factories;
using CSharpDesignPatternSamples.DesignPatterns.FactoryPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.FactoryPattern
{
    internal class FactoryPatternSample
    {
        public void Run()
        {
            // 1. 建立一個夏威夷披薩工廠
            PizzaFactory factory1 = new HawaiiPizzaFactory();
            Console.WriteLine("顧客點了夏威夷披薩：");
            IPizza pizza1 = factory1.OrderPizza();
            Console.WriteLine("\n--------------------------\n");

            // 2. 建立一個海鮮披薩工廠
            PizzaFactory factory2 = new SeafoodPizzaFactory();
            Console.WriteLine("顧客點了海鮮披薩：");
            IPizza pizza2 = factory2.OrderPizza();

            Console.ReadKey();
        }
    }
}
