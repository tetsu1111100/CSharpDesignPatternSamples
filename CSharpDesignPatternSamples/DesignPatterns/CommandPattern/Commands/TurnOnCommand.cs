

using CSharpDesignPatternSamples.DesignPatterns.CommandPattern.Interfaces;

namespace CSharpDesignPatternSamples.DesignPatterns.CommandPattern.Commands
{
    /// <summary>
    /// 具體命令：開啟電視
    /// </summary>
    internal class TurnOnCommand : ICommand
    {
        private readonly Television _television;

        public TurnOnCommand(Television television)
        {
            _television = television;
        }

        public void Execute()
        {
            _television.TurnOn();
        }
    }
}
