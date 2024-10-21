public class Memento
{
    public string DataName { get; }
    public int DataNumber { get; }
    public Memento(string dataName, int dataNumber)
    {
        DataName = dataName;
        DataNumber = dataNumber;
    }
}
