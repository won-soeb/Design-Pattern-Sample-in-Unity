public abstract class Handler
{
    protected Handler handler;
    public void SetNext(Handler next)
    {
        handler = next;
    }
    public void Handle(int request)
    {
        Process(request);
        if(handler != null) handler.Handle(request);
    }
    protected abstract void Process(int request);
}
