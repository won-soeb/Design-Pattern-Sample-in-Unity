public abstract class FactoryMethod
{
    public abstract IProduct CreateProduct();
    //Product ���� ����
    public void Create()
    {
        IProduct product = CreateProduct();
        product.Create();
    }
}
