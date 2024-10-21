using UnityEngine;

public class ProductB : IProduct
{
    public void Create()
    {
        Debug.Log(this + "를 생성합니다");
    }
}
