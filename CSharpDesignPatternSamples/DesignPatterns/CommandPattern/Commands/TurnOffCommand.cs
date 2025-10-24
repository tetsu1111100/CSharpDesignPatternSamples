

using CSharpDesignPatternSamples.DesignPatterns.CommandPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.CommandPattern.Commands
{
    /// <summary>
    /// 具體命令：關閉電視
    /// </summary>
    internal class TurnOffCommand : ICommand
    {
        private readonly Television _television;

        public TurnOffCommand(Television television)
        {
            _television = television;
        }

        public void Execute()
        {
            _television.TurnOff();
        }
    }
}
