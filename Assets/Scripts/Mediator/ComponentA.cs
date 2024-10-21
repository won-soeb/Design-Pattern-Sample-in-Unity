public class ComponentA : BaseComponent
{
    public ComponentA(IMediator mediator) : base(mediator)
    {
    }

    public override void Notify()
    {
        //기능을 추가할 수 있음
        mediator.Notify(this);
    }
    //다른 로직 추가 가능
}
