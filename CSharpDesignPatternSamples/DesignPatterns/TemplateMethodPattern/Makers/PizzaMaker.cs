
namespace CSharpDesignPatternSamples.DesignPatterns.TemplateMethodPattern.Makers
{
    public abstract class PizzaMaker
    {
        // 這就是樣板方法，定義了整個演算法的骨架
        public void MakePizza()
        {
            PrepareDough();
            AddIngredients(); // 這是抽象步驟，由子類別決定
            Bake();
            Cut();
            HookMethod(); // 鉤子方法，可選
        }

        // 具體步驟方法：所有披薩都一樣
        public void PrepareDough()
        {
            Console.WriteLine("1. 準備披薩麵團。");
        }

        // 抽象步驟方法：由子類別實作，例如：夏威夷披薩放鳳梨、海鮮披薩放蝦子
        public abstract void AddIngredients();

        // 具體步驟方法：所有披薩都一樣
        public void Bake()
        {
            Console.WriteLine("3. 烘烤披薩。");
        }

        // 具體步驟方法：所有披薩都一樣
        public void Cut()
        {
            Console.WriteLine("4. 切披薩。");
        }

        // 鉤子方法：可選，子類別可以覆寫來插入額外的邏輯
        public virtual void HookMethod() { }
    }
}
