using UnityEngine;

public class Leaf1 : IComposite
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
