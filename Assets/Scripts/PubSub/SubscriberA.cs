using UnityEngine;

public class SubscriberA : ISubscribe
{
    public void Notified()
    {
        Debug.Log(this + " 가 알림을 받음");
    }
}
