using UnityEngine;

public class Singleton: MonoBehaviour
{
    private static Singleton _instance;

    // 싱글톤 인스턴스를 가져오는 프로퍼티
    public static Singleton Instance
    {
        get
        {
            // 인스턴스가 없으면 생성하여 반환
            if (_instance == null)
            {
                _instance = FindAnyObjectByType<Singleton>();
                DontDestroyOnLoad(_instance);
            }
            return _instance;
        }
    }

    // 초기화
    protected virtual void Awake()
    {
        // 인스턴스가 이미 있으면 중복 생성 방지
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            // 현재 인스턴스를 저장
            _instance = this;
        }
    }
    public void Print()
    {
        Debug.Log("싱글턴입니다.");
    }
}
