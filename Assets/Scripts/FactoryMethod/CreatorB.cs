public class CreatorB : FactoryMethod
{
    public override IProduct CreateProduct()
    {
        return new ProductB();
    }
}
