using UnityEngine;

public class ProductB2 : IProductB
{
    public void CreateProductB()
    {
        Debug.Log(this + "를 생성했습니다.");
    }
}
