public class Publisher
{
    private Broker broker;
    public Publisher(Broker broker)
    {
        this.broker = broker;
    }
    public void Notify()
    {
        broker.Publish();
    }
}
