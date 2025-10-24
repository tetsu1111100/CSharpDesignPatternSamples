
namespace CSharpDesignPatternSamples.DesignPatterns.AdapterPattern
{
    internal class OldVideoPlayer
    {
        /// <summary>
        /// 不相容的類別 (需要被轉接的舊播放器)
        /// </summary>
        /// <param name="videoPath"></param>
        public void PlayOldFormat(string videoPath)
        {
            Console.WriteLine($"舊播放器正在播放檔案: {videoPath}");
        }
    }
}
