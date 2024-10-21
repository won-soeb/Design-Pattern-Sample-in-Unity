using UnityEngine;

public class Originator
{
    private string dataName;
    private int dataNumber;
    public void Set(string dataName, int dataNumber)
    {
        this.dataName = dataName;
        this.dataNumber = dataNumber;
        Debug.Log($"{dataName}(이)가 {dataNumber} (을)를 설정함");
    }
    public Memento Save()
    {
        return new Memento(dataName, dataNumber);
    }
    public void Load(Memento memento)
    {
        dataName = memento.DataName;
        dataNumber = memento.DataNumber;
        Debug.Log($"{dataName}(이)가 {dataNumber} (을)를 불러옴");
    }
}
