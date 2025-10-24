
using CSharpDesignPatternSamples.DesignPatterns.FacadePattern.Systems;

namespace CSharpDesignPatternSamples.DesignPatterns.FacadePattern.Facades
{
    /// <summary>
    /// 門面
    /// </summary>
    public class SmartHomeFacade
    {
        private readonly LightSystem _lights = new LightSystem();
        private readonly AirConditionerSystem _ac = new AirConditionerSystem();
        private readonly MusicSystem _music = new MusicSystem();

        // 門面提供一個簡單的介面來啟動「觀影模式」
        public void StartMovieMode()
        {
            Console.WriteLine("\n--- 啟動「觀影模式」---");
            _lights.Dim();
            _ac.SetTemperature(24);
            _music.Play();
        }

        // 門面提供另一個簡單的介面來啟動「離家模式」
        public void LeaveHome()
        {
            Console.WriteLine("\n--- 啟動「離家模式」---");
            _lights.TurnOff();
            _ac.TurnOff();
            _music.Stop();
        }
    }
}
