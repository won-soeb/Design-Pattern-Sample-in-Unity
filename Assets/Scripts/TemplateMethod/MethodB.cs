using UnityEngine;

public class MethodB : TemplateMethod
{
    protected override void Step2()
    {
        Debug.Log("B 타입 2단계 실행");
    }
    protected override void Step3()
    {
        Debug.Log("B 타입 3단계 실행");
    }
    protected override void Step4()
    {
        Debug.Log("B 타입 4단계 실행");
    }
}
