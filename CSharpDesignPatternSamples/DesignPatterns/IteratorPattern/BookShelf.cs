
using CSharpDesignPatternSamples.DesignPatterns.IteratorPattern.Interfaces;
using CSharpDesignPatternSamples.DesignPatterns.IteratorPattern.Iterators;

namespace CSharpDesignPatternSamples.DesignPatterns.IteratorPattern
{
    /// <summary>
    /// 具體集合：書架
    /// </summary>
    public class BookShelf : IBookShelf
    {
        private readonly Book[] _books;
        private int _last = 0;

        public BookShelf(int maxSize) => _books = new Book[maxSize];

        public void AddBook(Book book)
        {
            if (_last < _books.Length)
            {
                _books[_last] = book;
                _last++;
            }
        }

        public IBookShelfIterator CreateIterator()
        {
            return new BookShelfIterator(this);
        }

        // 讓迭代器可以存取書本的公開屬性
        public Book GetBookAt(int index) => _books[index];
        public int Length => _last;
    }
}
