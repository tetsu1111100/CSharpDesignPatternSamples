
using CSharpDesignPatternSamples.DesignPatterns.CompositePattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.CompositePattern
{
    internal class File : IFileSystemComponent
    {
        public string Name { get; }
        public File(string name) => Name = name;

        public void ShowName()
        {
            Console.WriteLine($"檔案: {Name}");
        }
    }
}
