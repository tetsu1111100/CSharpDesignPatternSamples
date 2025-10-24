
using CSharpDesignPatternSamples.DesignPatterns.FactoryPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.FactoryPattern.Factories
{
    public abstract class PizzaFactory
    {
        // 這就是工廠方法，它回傳一個 IPizza 介面
        public abstract IPizza CreatePizza();

        // 也可以有其他處理邏輯
        public IPizza OrderPizza()
        {
            // 透過工廠方法來建立披薩，不關心具體是哪一種
            IPizza pizza = CreatePizza();

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();

            return pizza;
        }
    }
}
