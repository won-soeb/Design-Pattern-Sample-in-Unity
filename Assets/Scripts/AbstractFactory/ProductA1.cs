using UnityEngine;

public class ProductA1 : IProductA
{
    public void CreateProductA()
    {
        Debug.Log(this + "를 생성했습니다.");
    }
}
