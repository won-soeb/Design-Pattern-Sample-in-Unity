using UnityEngine;

public class HandlerC : Handler
{
    protected override void Process(int request)
    {
        if (request % 3 == 0) Debug.Log($"{request} �� 3�� ����Դϴ�");
    }
}