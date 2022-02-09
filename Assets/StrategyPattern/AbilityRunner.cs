using UnityEngine;

public class AbilityRunner : MonoBehaviour {
    [SerializeField] IAbility currentAbility = new RageAbilty();

    public void UseAbility()
    {
        currentAbility.Use();
    }
}
public interface IAbility
{
    void Use();
}
public class FireballAbility : IAbility
{
    public void Use()
    {
        Debug.Log("Launch Fireball");
    }
}
public class RageAbilty : IAbility
{
    public void Use()
    {
        Debug.Log("I'm always angry");
    }
}
public class HealAbility : IAbility
{
    public void Use()
    {
        Debug.Log("Here eat this!");
    }
}
