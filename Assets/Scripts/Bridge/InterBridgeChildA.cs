using UnityEngine;

public class InterBridgeChildA : IBridge
{
    public void IPrint(Bridge bridge)
    {
        Debug.Log(this + "�� �߻�Ŭ������ �����");
    }
    public void IPrint(IBridge bridge)
    {
        Debug.Log(bridge + "�� �������̽��� ��ӹ���");
    }
}
