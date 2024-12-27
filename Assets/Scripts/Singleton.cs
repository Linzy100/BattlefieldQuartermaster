using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    // ��̬ʵ������
    private static T _instance;

    // ������̬���ԣ��ṩȫ�ַ��ʵ�
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<T>();
                if (_instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(T).Name;
                    _instance = obj.AddComponent<T>();
                }
            }
            return _instance;
        }
    }

    // ȷ���ڳ����л�ʱ������
    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // ����Ѿ�����ʵ���������ٵ�ǰʵ��
            Destroy(gameObject);
        }
    }
}

