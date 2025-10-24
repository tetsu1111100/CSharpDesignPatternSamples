

using CSharpDesignPatternSamples.DesignPatterns.CommandPattern.Commands;
using CSharpDesignPatternSamples.DesignPatterns.CommandPattern.Controls;
using CSharpDesignPatternSamples.DesignPatterns.CommandPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.CommandPattern
{
    internal class CommandPatternSample
    {
        public void Run()
        {
            // 1. 建立接收者 (電視)
            Television tv = new Television();

            // 2. 建立具體命令，並將接收者傳入
            ICommand turnOnCommand = new TurnOnCommand(tv);
            ICommand turnOffCommand = new TurnOffCommand(tv);

            // 3. 建立請求者 (遙控器)
            RemoteControl remote = new RemoteControl();

            // 4. 將命令綁定到遙控器
            Console.WriteLine("--- 設定「開啟電視」命令 ---");
            remote.SetCommand(turnOnCommand);
            remote.PressButton();

            Console.WriteLine("\n--- 設定「關閉電視」命令 ---");
            remote.SetCommand(turnOffCommand);
            remote.PressButton();

            Console.ReadKey();
        }
    }
}
