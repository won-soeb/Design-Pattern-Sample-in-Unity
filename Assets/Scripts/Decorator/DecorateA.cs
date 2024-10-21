using UnityEngine;

public class DecorateA : BaseDecorator, IDecorator
{
    public DecorateA(IDecorator decorator) : base(decorator) { }
    public void Execute()
    {
        base.Execute();
        Debug.Log(this + "��ü�� �����մϴ�.");
    }
}
