using UnityEngine;

public class InterBridgeChildA : IBridge
{
    public void IPrint(Bridge bridge)
    {
        Debug.Log(this + "가 추상클래스에 연결됨");
    }
    public void IPrint(IBridge bridge)
    {
        Debug.Log(bridge + "가 인터페이스를 상속받음");
    }
}
