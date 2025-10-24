
namespace CSharpDesignPatternSamples.DesignPatterns.FacadePattern.Systems
{
    /// <summary>
    /// 子系統 - 空調
    /// </summary>
    public class AirConditionerSystem
    {
        public void TurnOn() => Console.WriteLine("空調已開啟。");
        public void TurnOff() => Console.WriteLine("空調已關閉。");
        public void SetTemperature(int temp) => Console.WriteLine($"空調溫度設定為 {temp} 度。");
    }
}
