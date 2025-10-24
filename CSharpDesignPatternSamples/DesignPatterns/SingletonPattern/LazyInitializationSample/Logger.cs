
namespace CSharpDesignPatternSamples.DesignPatterns.SingletonPattern.LazyInitializationSample
{
    /// <summary>
    /// 餓漢式 (Eager Initialization) - 執行緒安全
    /// </summary>
    public sealed class Logger
    {
        // 1. 私有的靜態實例變數，直接在宣告時初始化
        private static readonly Logger _instance = new Logger();

        // 2. 私有的建構子，防止外部直接 new 實例
        private Logger()
        {
            Console.WriteLine("Logger 實例已建立。");
        }

        // 3. 公有的靜態方法，提供全域存取點
        public static Logger Instance
        {
            get
            {
                return _instance;
            }
        }

        // 4. 類別的業務方法
        public void Log(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
    }
}
