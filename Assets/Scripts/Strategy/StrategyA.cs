using UnityEngine;

public class StrategyA : IStrategy
{
    //�߰� ����
    public void Execute(string strategy)
    {
        Debug.Log($"A ���� {strategy} �Դϴ�.");
    }
}
