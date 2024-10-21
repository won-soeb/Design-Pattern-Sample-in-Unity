public class ComponentA : BaseComponent
{
    public ComponentA(IMediator mediator) : base(mediator)
    {
    }

    public override void Notify()
    {
        //����� �߰��� �� ����
        mediator.Notify(this);
    }
    //�ٸ� ���� �߰� ����
}
