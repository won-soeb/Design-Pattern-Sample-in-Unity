public class FactoryClient
{
    private IProductA productA; 
    private IProductB productB;
    public FactoryClient(IAbstractFactory factory)
    {
        productA = factory.CreateProductA();
        productB = factory.CreateProductB();
    }
    public void Create()
    {
        productA.CreateProductA();
        productB.CreateProductB();
    }
}
