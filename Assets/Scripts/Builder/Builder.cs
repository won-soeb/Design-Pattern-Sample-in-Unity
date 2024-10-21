using UnityEngine;

public class Builder
{
    private int id;
    private string name;
    private int age;
    private string job;

    public Builder(BuildManager build)
    {
        id = build.id;
        name = build.name;
        age = build.age;
        job = build.job;
    }
    public void Print()
    {
        Debug.LogFormat("ID : {0}, 이름 : {1}, 나이 : {2}, 직업 : {3}", id, name, age, job);
    }
}
