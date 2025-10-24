
using CSharpDesignPatternSamples.DesignPatterns.AdapterPattern.Adapers;
using CSharpDesignPatternSamples.DesignPatterns.AdapterPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.AdapterPattern
{
    internal class AdapterPatternSample
    {
        public void Run()
        {
            // 客戶端只知道 IVideoPlayer 介面
            IVideoPlayer player = new OldPlayerAdapter();

            // 透過轉接器，我們可以使用舊的播放器來播放影片
            player.Play("我的老影片.avi");

            Console.ReadKey();
        }
    }
}
