
namespace CSharpDesignPatternSamples.DesignPatterns.IteratorPattern.Interfaces
{
    /// <summary>
    /// 迭代器介面
    /// </summary>
    public interface IBookShelfIterator
    {
        bool HasNext();
        Book Next();
    }
}
