using UnityEngine;

public class SubscriberB : ISubscribe
{
    public void Notified()
    {
        Debug.Log(this + " �� �˸��� ����");
    }
}
