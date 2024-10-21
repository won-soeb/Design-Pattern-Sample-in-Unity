using UnityEngine;

public class BridgeChildA : Bridge
{
    public BridgeChildA(IBridge bridge) : base(bridge)
    {

    }
    public override void Print(Bridge bridge)
    {
        Debug.Log(bridge + "가 추상클래스를 상속받음");
    }
    public override void Print(IBridge bridge)
    {
        Debug.Log(this + "가 인터페이스에 연결됨");
    }
}
