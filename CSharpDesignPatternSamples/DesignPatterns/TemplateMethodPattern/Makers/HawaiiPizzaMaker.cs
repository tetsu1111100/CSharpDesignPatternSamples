
namespace CSharpDesignPatternSamples.DesignPatterns.TemplateMethodPattern.Makers
{
    /// <summary>
    /// 夏威夷披薩具體類別
    /// </summary>
    public class HawaiiPizzaMaker : PizzaMaker
    {
        // 實作抽象步驟：加入配料
        public override void AddIngredients()
        {
            Console.WriteLine("2. 加入夏威夷披薩的配料：火腿、鳳梨和起司。");
        }
    }
}
