using UnityEngine;

public class HandlerA : Handler
{
    protected override void Process(int request)
    {
        if (request > 0) Debug.Log($"{request} 는 양수입니다");
    }
}
