using UnityEngine;

public class AbilityRunner : MonoBehaviour {
    //[SerializeField] IAbility currentAbility = new DelayedDecorator( new RageAbilty());
    // example for decorator pattern

    [SerializeField]
    IAbility currentAbility =
        new SequenceComposite(
            new IAbility[] {
                new HealAbility(),
                new RageAbilty (),
                new DelayedDecorator(new RageAbilty())
                }
            );
    public void UseAbility()
    {
        currentAbility.Use(gameObject);
    }
}
public interface IAbility
{
    void Use(GameObject currentGameObject);
}
public class SequenceComposite : IAbility
{
    public IAbility[] children;
    public SequenceComposite(IAbility[] children)
    {
        this.children = children;
    }

    public void Use(GameObject currentGameObject)
    {
       foreach (var child in children)
        {
            child.Use(currentGameObject);
        }
    }
}
public class DelayedDecorator : IAbility
{
    private IAbility wrappedAbility;

    public DelayedDecorator(IAbility wrappedAbility)
    {
        this.wrappedAbility = wrappedAbility;
    }

    public void Use(GameObject currentGameObject)
    {
        // do some delayed operation
        wrappedAbility.Use(currentGameObject);
    }
}
public class FireballAbility : IAbility
{
    public void Use(GameObject currentGameObject)
    {
        Debug.Log("Launch Fireball");
    }
}
public class RageAbilty : IAbility
{
    public void Use(GameObject currentGameObject)
    {
        Debug.Log("I'm always angry");
    }
}
public class HealAbility : IAbility
{
    public void Use(GameObject currentGameObject)
    {
        Debug.Log("Here eat this!");
    }
}
