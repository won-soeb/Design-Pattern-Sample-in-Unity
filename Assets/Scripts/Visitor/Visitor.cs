//�ʿ信 ���� �������� Ŭ������ ������ �� ����
public class Visitor : IVisitor
{
    public void Visit(ElementA elementA)
    {
        //�߰� ����
        elementA.Feature();
    }

    public void Visit(ElementB elementB)
    {
        //�߰� ����
        elementB.Feature();
    }
}
