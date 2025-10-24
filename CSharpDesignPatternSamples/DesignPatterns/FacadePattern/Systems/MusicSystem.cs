
namespace CSharpDesignPatternSamples.DesignPatterns.FacadePattern.Systems
{
    /// <summary>
    /// 子系統 - 音樂
    /// </summary>
    public class MusicSystem
    {
        public void Play() => Console.WriteLine("音樂已播放。");
        public void Stop() => Console.WriteLine("音樂已停止。");
    }
}
