using UnityEngine;

public class Originator
{
    private string dataName;
    private int dataNumber;
    public void Set(string dataName, int dataNumber)
    {
        this.dataName = dataName;
        this.dataNumber = dataNumber;
        Debug.Log($"{dataName}(��)�� {dataNumber} (��)�� ������");
    }
    public Memento Save()
    {
        return new Memento(dataName, dataNumber);
    }
    public void Load(Memento memento)
    {
        dataName = memento.DataName;
        dataNumber = memento.DataNumber;
        Debug.Log($"{dataName}(��)�� {dataNumber} (��)�� �ҷ���");
    }
}
