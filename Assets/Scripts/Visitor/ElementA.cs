using UnityEngine;

public class ElementA : IElement
{
    public ElementA() => Debug.Log(this + "�� �⺻����Դϴ�");

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
