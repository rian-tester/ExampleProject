using UnityEngine;

public class TheProjectile : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        transform.Translate(new Vector2(speed, 0) * Time.deltaTime);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
