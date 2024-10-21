using UnityEngine;

public class ObserverB : IObserver
{
    public void Notify()
    {
        Debug.Log(this + "가 알림을 받았습니다");
    }
}
