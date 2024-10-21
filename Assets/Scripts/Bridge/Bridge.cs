public abstract class Bridge
{
    protected IBridge bridge;
    protected Bridge(IBridge bridge)
    {
        this.bridge = bridge;
    }
    public abstract void Print(Bridge bridge);
    public abstract void Print(IBridge bridge);
}
