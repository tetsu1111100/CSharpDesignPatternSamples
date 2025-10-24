
namespace CSharpDesignPatternSamples.DesignPatterns.SingletonPattern
{
    internal class SingletonPatternSample
    {
        /// <summary>
        /// 範例：使用懶漢式 (Lazy Initialization) 實現單例模式
        /// </summary>
        public void Run1()
        {
            CSharpDesignPatternSamples.DesignPatterns.SingletonPattern.EagerInitializationSample.Logger logger1 = CSharpDesignPatternSamples.DesignPatterns.SingletonPattern.EagerInitializationSample.Logger.Instance;
            CSharpDesignPatternSamples.DesignPatterns.SingletonPattern.EagerInitializationSample.Logger logger2 = CSharpDesignPatternSamples.DesignPatterns.SingletonPattern.EagerInitializationSample.Logger.Instance;

            // 比較兩個變數是否指向同一個實例
            if (logger1 == logger2)
            {
                Console.WriteLine("\nlogger1 和 logger2 參考的是同一個 Logger 實例。");
            }

            // 透過實例來呼叫方法
            logger1.Log("程式啟動...");
            logger2.Log("使用者登入成功。");

            Console.ReadKey();
        }

        /// <summary>
        /// 範例：使用餓漢式 (Eager Initialization) 實現單例模式
        /// </summary>
        public void Run2()
        {
            CSharpDesignPatternSamples.DesignPatterns.SingletonPattern.EagerInitializationSample.Logger logger1 = CSharpDesignPatternSamples.DesignPatterns.SingletonPattern.EagerInitializationSample.Logger.Instance;
            CSharpDesignPatternSamples.DesignPatterns.SingletonPattern.EagerInitializationSample.Logger logger2 = CSharpDesignPatternSamples.DesignPatterns.SingletonPattern.EagerInitializationSample.Logger.Instance;

            // 比較兩個變數是否指向同一個實例
            if (logger1 == logger2)
            {
                Console.WriteLine("\nlogger1 和 logger2 參考的是同一個 Logger 實例。");
            }

            // 透過實例來呼叫方法
            logger1.Log("程式啟動...");
            logger2.Log("使用者登入成功。");

            Console.ReadKey();
        }
    }
}
