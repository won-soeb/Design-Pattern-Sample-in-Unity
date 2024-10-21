using UnityEngine;

public class BridgeChildB : Bridge
{
    public BridgeChildB(IBridge bridge) : base(bridge)
    {

    }
    public override void Print(Bridge bridge)
    {
        Debug.Log(bridge + "�� �߻�Ŭ������ ��ӹ���");
    }
    public override void Print(IBridge bridge)
    {
        Debug.Log(this + "�� �������̽��� �����");
    }
}
