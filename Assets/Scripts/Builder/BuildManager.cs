public class BuildManager
{
    public int id;
    public string name;
    public int age;
    public string job;

    public Builder Build()
    {
        return new Builder(this);
    }
    public BuildManager Id(int id)
    {
        this.id = id;
        return this;
    }
    public BuildManager Name(string name)
    {
        this.name = name;
        return this;
    }
    public BuildManager Age(int age)
    {
        this.age = age;
        return this;
    }
    public BuildManager Job(string job)
    {
        this.job = job;
        return this;
    }
}
