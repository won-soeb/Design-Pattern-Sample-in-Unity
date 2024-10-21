public interface IComposite
{
    public void LoadNames();
    public void Add(IComposite component);
    public void Remove(IComposite component);
}
