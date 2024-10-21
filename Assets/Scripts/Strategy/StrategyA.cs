using UnityEngine;

public class StrategyA : IStrategy
{
    //추가 로직
    public void Execute(string strategy)
    {
        Debug.Log($"A 전략 {strategy} 입니다.");
    }
}
