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
            //원본 객체 사용
            original = new Original();
            original.Use();
        }
        else
        {
            Debug.Log("프록시를 사용합니다");
        }
    }
}
