public class ComponentB : BaseComponent
{
    public ComponentB(IMediator mediator) : base(mediator)
    {
    }

    public override void Notify()
    {
        //����� �߰��� �� ����
        mediator.Notify(this);
    }
    //�ٸ� ���� �߰� ����
}
