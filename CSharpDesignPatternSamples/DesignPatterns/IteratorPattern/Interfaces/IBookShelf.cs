
namespace CSharpDesignPatternSamples.DesignPatterns.IteratorPattern.Interfaces
{
    /// <summary>
    /// 集合介面
    /// </summary>
    public interface IBookShelf
    {
        IBookShelfIterator CreateIterator();
    }
}
