using UnityEngine;

public class Leaf2 : IComposite
{
    public void Add(IComposite component)
    {
        throw new System.NotImplementedException();
    }

    public void Remove(IComposite component)
    {
        throw new System.NotImplementedException();
    }

    public void LoadNames()
    {
        Debug.Log(this);
    }
}
