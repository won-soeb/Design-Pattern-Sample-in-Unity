public abstract class FactoryMethod
{
    public abstract IProduct CreateProduct();
    //Product 최종 생성
    public void Create()
    {
        IProduct product = CreateProduct();
        product.Create();
    }
}
