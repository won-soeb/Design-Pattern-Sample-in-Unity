using UnityEngine;

public class ObserverB : IObserver
{
    public void Notify()
    {
        Debug.Log(this + "�� �˸��� �޾ҽ��ϴ�");
    }
}
