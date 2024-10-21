using UnityEngine;

public class Singleton: MonoBehaviour
{
    private static Singleton _instance;

    // �̱��� �ν��Ͻ��� �������� ������Ƽ
    public static Singleton Instance
    {
        get
        {
            // �ν��Ͻ��� ������ �����Ͽ� ��ȯ
            if (_instance == null)
            {
                _instance = FindAnyObjectByType<Singleton>();
                DontDestroyOnLoad(_instance);
            }
            return _instance;
        }
    }

    // �ʱ�ȭ
    protected virtual void Awake()
    {
        // �ν��Ͻ��� �̹� ������ �ߺ� ���� ����
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            // ���� �ν��Ͻ��� ����
            _instance = this;
        }
    }
    public void Print()
    {
        Debug.Log("�̱����Դϴ�.");
    }
}
