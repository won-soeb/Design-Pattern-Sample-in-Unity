using UnityEngine;

public class DecorateA : BaseDecorator, IDecorator
{
    public DecorateA(IDecorator decorator) : base(decorator) { }
    public void Execute()
    {
        base.Execute();
        Debug.Log(this + "객체를 조합합니다.");
    }
}
