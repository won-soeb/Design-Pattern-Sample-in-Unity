using UnityEngine;

public class Proxy : IProxy
{
    private Original original;
    private string isProxy;

    public Proxy(string isProxy)
    {
        this.isProxy = isProxy;
    }

    public void Use()
    {
        if (isProxy == "Original")
        {
            //���� ��ü ���
            original = new Original();
            original.Use();
        }
        else
        {
            Debug.Log("���Ͻø� ����մϴ�");
        }
    }
}
