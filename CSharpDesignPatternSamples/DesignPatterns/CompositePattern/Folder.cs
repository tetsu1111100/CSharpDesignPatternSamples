

using CSharpDesignPatternSamples.DesignPatterns.CompositePattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.CompositePattern
{
    /// <summary>
    /// 複合節點：資料夾
    /// </summary>
    public class Folder : IFileSystemComponent
    {
        public string Name { get; }
        private readonly List<IFileSystemComponent> _components = new List<IFileSystemComponent>();

        public Folder(string name) => Name = name;

        public void AddComponent(IFileSystemComponent component)
        {
            _components.Add(component);
        }

        public void ShowName()
        {
            Console.WriteLine($"資料夾: {Name}");
            foreach (var component in _components)
            {
                component.ShowName(); // 遞迴呼叫子元件的 ShowName() 方法
            }
        }
    }
}
