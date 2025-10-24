
using CSharpDesignPatternSamples.DesignPatterns.StatePattern.Interfaces;
using CSharpDesignPatternSamples.DesignPatterns.StatePattern.States;

namespace CSharpDesignPatternSamples.DesignPatterns.StatePattern
{
    /// <summary>
    /// 內容：咖啡機
    /// </summary>
    public class CoffeeMachine
    {
        private IState _currentState;

        public CoffeeMachine()
        {
            // 咖啡機啟動時，預設為閒置狀態
            _currentState = new IdleState(this);
        }

        // 改變狀態的方法
        public void SetState(IState newState)
        {
            _currentState = newState;
        }

        // 將請求轉發給當前狀態物件
        public void InsertCoin() => _currentState.InsertCoin();
        public void PressButton() => _currentState.PressButton();
        public void RefundCoin() => _currentState.RefundCoin();
    }
}
