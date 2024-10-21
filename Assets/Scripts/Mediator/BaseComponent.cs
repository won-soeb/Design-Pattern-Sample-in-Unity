public abstract class BaseComponent
{
    protected IMediator mediator;
    public BaseComponent(IMediator mediator)
    {
        this.mediator = mediator;
    }
    public abstract void Notify();
}
