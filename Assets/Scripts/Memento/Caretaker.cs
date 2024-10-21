using System.Collections.Generic;
using UnityEngine;

public class Caretaker
{
    private Dictionary<string, Memento> mementos = new Dictionary<string, Memento>();
    public void AddMemento(Memento memento)
    {
        mementos.Add(memento.DataName, memento);
    }
    public Memento GetMemento(string dataName)
    {
        if (mementos.ContainsKey(dataName))
        {
            return mementos[dataName];
        }
        else
        {
            Debug.Log(dataName + " (이)가 없습니다");
            return new Memento("None", 0);
        }
    }
}
