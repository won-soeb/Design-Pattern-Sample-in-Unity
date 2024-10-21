using UnityEngine;

public class Original : IProxy
{
    public void Use()
    {
        Debug.Log("원본을 사용합니다");
    }
}
