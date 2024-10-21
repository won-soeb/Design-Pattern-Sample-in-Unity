using UnityEngine;

public class ProductA2 : IProductA
{
    public void CreateProductA()
    {
        Debug.Log(this + "를 생성했습니다.");
    }
}
