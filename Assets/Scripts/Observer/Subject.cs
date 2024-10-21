using System.Collections.Generic;

public class Subject : IObserver
{
    private List<IObserver> observers = new List<IObserver>();

    public void Notify()
    {
        if (observers.Count == 0) return;
        foreach (var observer in observers)
        {
            observer.Notify();
        }
    }
    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }
    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }
}
