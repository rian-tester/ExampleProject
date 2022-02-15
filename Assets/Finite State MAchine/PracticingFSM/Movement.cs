using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float rotationSpeed = 50f;

    private Rigidbody2D myRigidBody;

    public event Action onMoving;
    public event Action onRotating;
    public event Action onStopping;
    private void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (myRigidBody.velocity == Vector2.zero) onStopping();
        Moving();
        Rotating();
    }
    void Moving()
    {
        float translation = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0,translation,0);

        if (translation > 0 || translation < 0) onMoving();       
    }
    void Rotating()
    {
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime *-1f;
        transform.Rotate(0, 0, rotation);

        if (rotation > 0 || rotation < 0) onRotating(); 
    }
}
