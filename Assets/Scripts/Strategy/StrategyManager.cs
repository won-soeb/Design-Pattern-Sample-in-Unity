public class StrategyManager
{
    private IStrategy strategy;

    public void setStrategy(IStrategy strategy)
    {
        this.strategy = strategy;
    }
    public void ChangeStrategy(string strategy)
    {
        this.strategy.Execute(strategy);
    }
}
