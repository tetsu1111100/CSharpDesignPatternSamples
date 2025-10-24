
using CSharpDesignPatternSamples.DesignPatterns.IteratorPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.IteratorPattern
{
    internal class IteratorPatternSample
    {
        public void Run()
        {
            BookShelf bookShelf = new BookShelf(4);
            bookShelf.AddBook(new Book("書本A"));
            bookShelf.AddBook(new Book("書本B"));
            bookShelf.AddBook(new Book("書本C"));

            IBookShelfIterator iterator = bookShelf.CreateIterator();
            while (iterator.HasNext())
            {
                Book book = iterator.Next();
                Console.WriteLine($"正在閱讀: {book.Name}");
            }
        }
    }
}
