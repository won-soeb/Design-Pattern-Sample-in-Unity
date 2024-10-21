using System.Collections.Generic;

public class FlyweightFactory
{
    private static Dictionary<string, Flyweight> datas = new Dictionary<string, Flyweight>();
    private static int count = 0;
    public static Flyweight GetData(string name)
    {
        count++;
        datas.Add(name, new Flyweight(name, count));
        return datas[name];
    }
}
