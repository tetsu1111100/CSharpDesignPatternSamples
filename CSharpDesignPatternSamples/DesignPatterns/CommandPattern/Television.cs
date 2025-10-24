
namespace CSharpDesignPatternSamples.DesignPatterns.CommandPattern
{
    /// <summary>
    /// 接收者：電視
    /// </summary>
    internal class Television
    {
        public void TurnOn()
        {
            Console.WriteLine("電視已開啟。");
        }

        public void TurnOff()
        {
            Console.WriteLine("電視已關閉。");
        }
    }
}
