//필요에 따라서 여러개의 클래스를 정의할 수 있음
public class Visitor : IVisitor
{
    public void Visit(ElementA elementA)
    {
        //추가 가능
        elementA.Feature();
    }

    public void Visit(ElementB elementB)
    {
        //추가 가능
        elementB.Feature();
    }
}
