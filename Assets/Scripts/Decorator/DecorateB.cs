using UnityEngine;

public class DecorateB : BaseDecorator, IDecorator
{
    public DecorateB(IDecorator decorator) : base(decorator) { }
    public void Execute()
    {
        base.Execute();
        Debug.Log(this + "��ü�� �����մϴ�.");
    }
}
