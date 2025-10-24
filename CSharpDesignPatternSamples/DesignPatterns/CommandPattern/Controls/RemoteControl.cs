

using CSharpDesignPatternSamples.DesignPatterns.CommandPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.CommandPattern.Controls
{
    /// <summary>
    /// 請求者：遙控器
    /// </summary>
    internal class RemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        // 按下按鈕，執行命令
        public void PressButton()
        {
            _command.Execute();
        }
    }
}
