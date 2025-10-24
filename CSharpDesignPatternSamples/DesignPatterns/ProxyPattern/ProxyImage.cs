
using CSharpDesignPatternSamples.DesignPatterns.ProxyPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.ProxyPattern
{
    /// <summary>
    /// 代理主體：控制對真實圖片的存取
    /// </summary>
    public class ProxyImage : IImage
    {
        private readonly string _filename;
        private RealImage _realImage; // 代理持有對真實圖片的引用

        public ProxyImage(string filename)
        {
            _filename = filename;
            Console.WriteLine($"ProxyImage 已建立，但圖片尚未載入。");
        }

        public void Display()
        {
            // 只有在第一次呼叫 Display() 時才建立 RealImage 實例
            if (_realImage == null)
            {
                Console.WriteLine("第一次顯示圖片，透過代理載入真實圖片...");
                _realImage = new RealImage(_filename);
            }

            // 將請求轉發給 RealImage
            _realImage.Display();
        }
    }
}
