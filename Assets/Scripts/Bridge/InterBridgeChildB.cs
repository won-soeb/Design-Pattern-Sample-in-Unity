using UnityEngine;

public class InterBridgeChildB : IBridge
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
