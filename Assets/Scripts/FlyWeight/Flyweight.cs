using UnityEngine;

public class Flyweight
{
    private string name;
    public int idx = 0;

    public Flyweight(string name, int idx)
    {
        this.name = name;
        this.idx = idx;
    }
    public void Print()
    {
        Debug.Log($"{idx}번째 데이터 : {name}");
    }
}