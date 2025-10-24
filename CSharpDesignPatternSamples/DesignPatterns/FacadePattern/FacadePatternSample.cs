
using CSharpDesignPatternSamples.DesignPatterns.FacadePattern.Facades;

namespace CSharpDesignPatternSamples.DesignPatterns.FacadePattern
{
    internal class FacadePatternSample
    {
        public void Run()
        {
            // 客戶端只與門面互動
            SmartHomeFacade smartHome = new SmartHomeFacade();

            // 呼叫門面提供的簡單方法
            smartHome.StartMovieMode();

            Console.WriteLine();

            smartHome.LeaveHome();

            Console.ReadKey();
        }
    }
}
