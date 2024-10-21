using UnityEngine;

public class Adapter
{
    private IAdapter adapter;
    //Service�� ����
    public Adapter(IAdapter adapter)
    {
        this.adapter = adapter;
    }
    //ServiceŬ������ ����� Adapter�� ����� ��ȯ�ϴ� ����
    public void GetData(string name, float score)
    {
        float data = adapter.GetData();
        data = score;
        Debug.Log($"{name}�� ������ {score}�� �Դϴ�.");
    }
}
