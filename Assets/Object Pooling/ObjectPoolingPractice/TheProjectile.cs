using UnityEngine;
using UnityEngine.Pool;

public class TheProjectile : MonoBehaviour
{
    [SerializeField] float speed;

    private IObjectPool<TheProjectile> projectilePool;

    public void SetPool(IObjectPool<TheProjectile> projectile)
    {
        projectilePool = projectile;
    }

    void Update()
    {
        transform.Translate(new Vector2(speed, 0) * Time.deltaTime);
    }
    private void OnBecameInvisible()
    {
        projectilePool.Release(this);
    }
}
