using UnityEngine;

public class Adapter
{
    private IAdapter adapter;
    //Service와 연결
    public Adapter(IAdapter adapter)
    {
        this.adapter = adapter;
    }
    //Service클래스의 멤버를 Adapter의 멤버로 변환하는 로직
    public void GetData(string name, float score)
    {
        float data = adapter.GetData();
        data = score;
        Debug.Log($"{name}의 점수는 {score}점 입니다.");
    }
}
