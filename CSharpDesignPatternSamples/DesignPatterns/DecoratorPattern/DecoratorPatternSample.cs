
using CSharpDesignPatternSamples.DesignPatterns.DecoratorPattern.Decorators;
using CSharpDesignPatternSamples.DesignPatterns.DecoratorPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.DecoratorPattern
{
    internal class DecoratorPatternSample
    {
        public void Run()
        {
            // 1. 建立一個最基本的黑咖啡
            ICoffee coffee = new BlackCoffee();
            Console.WriteLine($"描述: {coffee.GetDescription()}, 價格: {coffee.GetCost():C}");

            // 2. 裝飾：加奶
            coffee = new MilkDecorator(coffee);
            Console.WriteLine($"描述: {coffee.GetDescription()}, 價格: {coffee.GetCost():C}");

            // 3. 裝飾：再加一份糖
            coffee = new SugarDecorator(coffee);
            Console.WriteLine($"描述: {coffee.GetDescription()}, 價格: {coffee.GetCost():C}");

            // 4. 裝飾：再加一份奶
            coffee = new MilkDecorator(coffee);
            Console.WriteLine($"描述: {coffee.GetDescription()}, 價格: {coffee.GetCost():C}");

            Console.ReadKey();
        }
    }
}

