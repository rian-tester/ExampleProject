using UnityEngine;

public class SingletonMono : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void SomeMethode()
    {
        // do something here
    }
}
