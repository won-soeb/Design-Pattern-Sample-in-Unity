using UnityEngine;

public class Origin : IDecorator
{
    public void Execute()
    {
        Debug.Log("원본 객체입니다");
    }
}
