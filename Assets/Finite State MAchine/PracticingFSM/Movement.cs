using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float rotationSpeed = 50f;

    private Rigidbody2D myRigidbody;

    public event Action onMoving;
    public event Action onRotating;
    public event Action onStill;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (myRigidbody.velocity == Vector2.zero)
        {
            if (onStill != null) onStill();
        }
        Moving();
        Rotating(); 
    }
    void Moving()
    {
        float translation = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        if (translation == 0) return;
        transform.Translate(0,translation,0);
        if (onMoving != null) onMoving();
    }
    void Rotating()
    {
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime *-1f;
        if (rotation == 0) return;
        transform.Rotate(0, 0, rotation);
        if (onRotating != null) onRotating();
    }
}
