

using CSharpDesignPatternSamples.DesignPatterns.AdapterPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.AdapterPattern.Adapers
{
    /// <summary>
    /// 轉接器
    /// </summary>
    internal class OldPlayerAdapter : IVideoPlayer
    {
        private readonly OldVideoPlayer _oldPlayer;

        public OldPlayerAdapter()
        {
            _oldPlayer = new OldVideoPlayer();
        }

        // 實作 IVideoPlayer 介面，並將其呼叫轉發給舊播放器
        public void Play(string filename)
        {
            // 在這裡，我們將新介面的 Play 方法轉換為舊播放器的 PlayOldFormat 方法
            _oldPlayer.PlayOldFormat(filename);
        }
    }
}
