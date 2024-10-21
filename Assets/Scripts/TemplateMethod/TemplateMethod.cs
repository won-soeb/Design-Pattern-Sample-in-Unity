using UnityEngine;

public abstract class TemplateMethod
{
    public void AllSteps()
    {
        Step1();
        Step2();
        Step3();
        Step4();
    }
    protected  void Step1()
    {
        Debug.Log("공통 1단계 실행");
    }
    protected abstract void Step2();
    protected abstract void Step3();
    protected abstract void Step4();
}
