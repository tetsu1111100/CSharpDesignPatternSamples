
using CSharpDesignPatternSamples.DesignPatterns.IteratorPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.IteratorPattern.Iterators
{
    /// <summary>
    /// 具體迭代器
    /// </summary>
    public class BookShelfIterator : IBookShelfIterator
    {
        private readonly BookShelf _bookShelf;
        private int _index = 0;

        public BookShelfIterator(BookShelf bookShelf) => _bookShelf = bookShelf;

        public bool HasNext() => _index < _bookShelf.Length;

        public Book Next()
        {
            Book book = _bookShelf.GetBookAt(_index);
            _index++;
            return book;
        }
    }
}
