public class FacadeManager
{
    //파사드 클래스를 추가할 수 있음
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
