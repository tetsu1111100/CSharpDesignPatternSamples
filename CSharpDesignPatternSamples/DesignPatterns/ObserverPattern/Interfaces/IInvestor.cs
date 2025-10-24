
namespace CSharpDesignPatternSamples.DesignPatterns.ObserverPattern.Interfaces
{
    /// <summary>
    /// 觀察者介面
    /// </summary>
    public interface IInvestor
    {
        void Update(IStock stock);
    }
}
