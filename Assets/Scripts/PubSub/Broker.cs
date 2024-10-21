using System.Collections.Generic;

public class Broker
{
    private List<ISubscribe> subscribers = new List<ISubscribe>();

    public void Subscribe(ISubscribe subscriber)
    {
        subscribers.Add(subscriber);
    }
    public void Publish()
    {
        if (subscribers.Count > 0)
        {
            foreach (ISubscribe subscriber in subscribers)
            {
                subscriber.Notified();
            }
        }
    }
}
