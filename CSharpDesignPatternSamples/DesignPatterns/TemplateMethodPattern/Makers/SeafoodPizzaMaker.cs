
namespace CSharpDesignPatternSamples.DesignPatterns.TemplateMethodPattern.Makers
{
    /// <summary>
    /// 海鮮披薩具體類別
    /// </summary>
    public class SeafoodPizzaMaker : PizzaMaker
    {
        // 實作抽象步驟：加入配料
        public override void AddIngredients()
        {
            Console.WriteLine("2. 加入海鮮披薩的配料：蝦仁、花枝和起司。");
        }

        // 覆寫鉤子方法，加入額外邏輯
        public override void HookMethod()
        {
            Console.WriteLine("5. 額外步驟：淋上海鮮醬汁。");
        }
    }
}
