using UnityEngine;

public class ObserverA : IObserver
{
    public void Notify()
    {
        Debug.Log(this + "�� �˸��� �޾ҽ��ϴ�");
    }
}
