
namespace CSharpDesignPatternSamples.DesignPatterns.SingletonPattern.EagerInitializationSample
{
    /// <summary>
    /// 懶漢式 (Lazy Initialization) - 執行緒安全
    /// </summary>
    /// <remarks>使用 sealed 防止其他類別繼承 Logger，從而避免子類別可能破壞單例模式的行為</remarks>
    public sealed class Logger
    {
        // 1. 私有的靜態實例變數，初始化為 null
        private static Logger _instance = null;

        // 2. 靜態的同步鎖物件
        private static readonly object _lock = new object();

        // 3. 私有的建構子，防止外部直接 new 實例
        private Logger()
        {
            Console.WriteLine("Logger 實例已建立。");
        }

        // 4. 公有的靜態方法，提供全域存取點
        public static Logger Instance
        {
            get
            {
                // 在多執行緒環境中，鎖住程式碼區塊 (當多個執行緒同時進入這個 get 區塊時，lock 會確保一次只有一個執行緒能執行這段程式碼，防止重複建立實例)
                lock (_lock)
                {
                    // 如果實例為 null，則建立一個新實例
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
                // 回傳唯一的實例
                return _instance;
            }
        }

        // 5. 類別的業務方法
        public void Log(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
    }
}
