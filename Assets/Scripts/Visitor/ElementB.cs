using UnityEngine;

public class ElementB : IElement
{
    public ElementB() => Debug.Log(this + "의 기본기능입니다");

    public void Accept(Visitor visit)
    {
        //방문자 기능 허용
        visit.Visit(this);
    }
    public void Feature()
    {
        Debug.Log(this + "의 기능을 추가합니다");
    }
}
