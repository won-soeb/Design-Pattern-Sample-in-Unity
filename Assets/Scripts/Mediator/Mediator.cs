using UnityEngine;

public class Mediator : IMediator
{
    //컴포넌트를 리스트로 관리해도 됨
    public void Notify(BaseComponent component)
    {
        Debug.Log($"{component}가 응답함");
        //컴포넌트 관리에 대한 로직 구현
    }
    //추가 로직 구현
}
