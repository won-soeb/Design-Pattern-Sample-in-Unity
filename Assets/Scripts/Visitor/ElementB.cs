using UnityEngine;

public class ElementB : IElement
{
    public ElementB() => Debug.Log(this + "�� �⺻����Դϴ�");

    public void Accept(Visitor visit)
    {
        //�湮�� ��� ���
        visit.Visit(this);
    }
    public void Feature()
    {
        Debug.Log(this + "�� ����� �߰��մϴ�");
    }
}
