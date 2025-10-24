

using CSharpDesignPatternSamples.DesignPatterns.CompositePattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.CompositePattern
{
    internal class CompositePatternSample
    {
        public void Run()
        {
            // 建立檔案和資料夾
            IFileSystemComponent file1 = new File("文件1.txt");
            IFileSystemComponent file2 = new File("文件2.txt");

            Folder subFolder = new Folder("子資料夾");
            subFolder.AddComponent(file2);

            Folder rootFolder = new Folder("根目錄");
            rootFolder.AddComponent(file1);
            rootFolder.AddComponent(subFolder);

            // 客戶端以統一的方式處理樹狀結構
            rootFolder.ShowName();

            Console.ReadKey();
        }
    }
}
