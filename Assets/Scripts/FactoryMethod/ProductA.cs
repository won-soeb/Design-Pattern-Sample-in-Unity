using UnityEngine;

public class ProductA : IProduct
{
    public void Create()
    {
        Debug.Log(this + "를 생성합니다");
    }
}
