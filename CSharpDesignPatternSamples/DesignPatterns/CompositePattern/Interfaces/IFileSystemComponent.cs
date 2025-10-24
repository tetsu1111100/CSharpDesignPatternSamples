

namespace CSharpDesignPatternSamples.DesignPatterns.CompositePattern.Interfaces
{
    /// <summary>
    /// 元件介面
    /// </summary>
    public interface IFileSystemComponent
    {
        string Name { get; }
        void ShowName();
    }
}
