
using CSharpDesignPatternSamples.DesignPatterns.ProxyPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.ProxyPattern
{
    /// <summary>
    /// 原始主體：真正載入並顯示圖片
    /// </summary>
    public class RealImage : IImage
    {
        private readonly string _filename;

        public RealImage(string filename)
        {
            _filename = filename;
            LoadImageFromDisk(); // 在建構子中模擬載入圖片的耗時操作
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine($"正在從磁碟載入圖片: {_filename}");
            // 模擬耗時操作
            System.Threading.Thread.Sleep(1000);
        }

        public void Display()
        {
            Console.WriteLine($"顯示圖片: {_filename}");
        }
    }
}
