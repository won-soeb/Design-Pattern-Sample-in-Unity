using UnityEngine;

public class SubscriberA : ISubscribe
{
    public void Notified()
    {
        Debug.Log(this + " �� �˸��� ����");
    }
}
