public class FacadeManager
{
    //�Ļ�� Ŭ������ �߰��� �� ����
    private FacadeA a;
    private FacadeB b;
    public void Init()
    {
        a = new FacadeA();
        b = new FacadeB();
    }
    public void Print()
    {
        a.Print();
        b.Print();
    }
}
