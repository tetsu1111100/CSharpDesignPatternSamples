
namespace CSharpDesignPatternSamples.DesignPatterns.FacadePattern.Systems
{
    /// <summary>
    /// 子系統 - 燈光
    /// </summary>
    public class LightSystem
    {
        public void TurnOn() => Console.WriteLine("燈光已開啟。");
        public void TurnOff() => Console.WriteLine("燈光已關閉。");
        public void Dim() => Console.WriteLine("燈光已調暗。");
    }
}
