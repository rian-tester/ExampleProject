using UnityEngine;

public class SingletonMono : MonoBehaviour
{
    private static SingletonMono instance = null;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }
    public void SomeMethode()
    {
        // do something here
    }
}
