using System;


public class SingletonSimple 
{
    private static SingletonSimple instance = null;
    public static SingletonSimple GetInstance()
    {
        if (instance == null)
        {
            instance = new SingletonSimple();
        }
        return instance;
    }
    public void SomeMethode()
    {
        //do something here
    }
}
