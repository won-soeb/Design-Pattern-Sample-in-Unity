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
        Debug.Log("���� 1�ܰ� ����");
    }
    protected abstract void Step2();
    protected abstract void Step3();
    protected abstract void Step4();
}
