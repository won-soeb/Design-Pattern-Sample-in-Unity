using System.Collections.Generic;
using UnityEngine;

public class Composite : IComposite
{
    private List<IComposite> composites = new List<IComposite>();
    public void Add(IComposite component)
    {
        composites.Add(component);
    }

    public void Remove(IComposite component)
    {
        composites.Remove(component);
    }

    public void LoadNames()
    {
        foreach (var component in composites)
        {
            Debug.Log(component);
        }
    }
}
