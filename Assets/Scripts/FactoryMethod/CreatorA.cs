public class CreatorA : FactoryMethod
{
    public override IProduct CreateProduct()
    {
        return new ProductA();
    }
}
