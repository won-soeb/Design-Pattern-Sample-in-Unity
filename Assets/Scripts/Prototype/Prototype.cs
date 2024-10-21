using UnityEngine;

public class Prototype : IPrototype
{
    public int DataId { get; set; }
    public string DataName { get; set; }
    public Prototype(int dataId, string dataName)
    {
        DataId = dataId;
        DataName = dataName;
    }
    public Prototype(Prototype prototype)
    {
        DataId = prototype.DataId;
        DataName = prototype.DataName;
    }
    public Prototype Clone()
    {
        return new Prototype(this);
    }
    public void LoadData()
    {
        Debug.Log($"DataID :{DataId}, DataName : {DataName}");
    }
}
