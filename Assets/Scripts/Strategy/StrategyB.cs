using UnityEngine;

public class StrategyB : IStrategy
{
    //�߰� ����
    public void Execute(string strategy)
    {
        Debug.Log($"B ���� {strategy} �Դϴ�.");
    }
}
