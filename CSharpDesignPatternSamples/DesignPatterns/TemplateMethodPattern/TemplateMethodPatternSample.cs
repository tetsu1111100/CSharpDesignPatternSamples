
using CSharpDesignPatternSamples.DesignPatterns.TemplateMethodPattern.Makers;

namespace CSharpDesignPatternSamples.DesignPatterns.TemplateMethodPattern
{
    internal class TemplateMethodPatternSample
    {
        public void Run()
        {
            // 1. 製作夏威夷披薩
            PizzaMaker hawaiiPizzaMaker = new HawaiiPizzaMaker();
            Console.WriteLine("--- 開始製作夏威夷披薩 ---");
            hawaiiPizzaMaker.MakePizza();
            Console.WriteLine("\n--------------------------\n");

            // 2. 製作海鮮披薩
            PizzaMaker seafoodPizzaMaker = new SeafoodPizzaMaker();
            Console.WriteLine("--- 開始製作海鮮披薩 ---");
            seafoodPizzaMaker.MakePizza();

            Console.ReadKey();
        }
    }
}
