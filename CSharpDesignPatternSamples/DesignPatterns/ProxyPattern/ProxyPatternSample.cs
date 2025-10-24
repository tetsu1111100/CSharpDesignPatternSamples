
using CSharpDesignPatternSamples.DesignPatterns.ProxyPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.ProxyPattern
{
    internal class ProxyPatternSample
    {
        public void Run()
        {
            Console.WriteLine("程式開始，建立兩個圖片代理物件...");

            // 建立 ProxyImage 實例，此時 RealImage 尚未載入
            IImage image1 = new ProxyImage("photo1.jpg");
            IImage image2 = new ProxyImage("photo2.jpg");

            Console.WriteLine("\n--- 圖片列表已準備好 ---");

            // 第一次呼叫 Display()，RealImage 才會被載入
            Console.WriteLine("\n--- 顯示第一張圖片 ---");
            image1.Display();

            // 再次呼叫 Display()，此時 RealImage 已存在，無需再次載入
            Console.WriteLine("\n--- 再次顯示第一張圖片 ---");
            image1.Display();

            // 第一次呼叫 Display()，RealImage 才會被載入
            Console.WriteLine("\n--- 顯示第二張圖片 ---");
            image2.Display();

            Console.ReadKey();
        }
    }
}
