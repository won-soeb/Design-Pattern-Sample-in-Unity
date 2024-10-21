public class BaseDecorator : IDecorator
{
    private IDecorator decorator;
    public BaseDecorator(IDecorator decorator)
    {
        this.decorator = decorator;
    }
    public void Execute()
    {
        decorator.Execute();
    }
}
