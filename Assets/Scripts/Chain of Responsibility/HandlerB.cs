using UnityEngine;

public class HandlerB : Handler
{
    protected override void Process(int request)
    {
        if (request % 2 == 0) Debug.Log($"{request} 는 짝수입니다");
    }
}
