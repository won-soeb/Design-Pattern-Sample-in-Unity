using UnityEngine;

public class DecorateB : BaseDecorator, IDecorator
{
    public DecorateB(IDecorator decorator) : base(decorator) { }
    public void Execute()
    {
        base.Execute();
        Debug.Log(this + "객체를 조합합니다.");
    }
}
