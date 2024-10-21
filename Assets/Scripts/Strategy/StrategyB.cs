using UnityEngine;

public class StrategyB : IStrategy
{
    //추가 로직
    public void Execute(string strategy)
    {
        Debug.Log($"B 전략 {strategy} 입니다.");
    }
}
