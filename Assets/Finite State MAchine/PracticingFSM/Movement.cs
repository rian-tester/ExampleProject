using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float rotationSpeed = 50f;

    void Update()
    {
        Moving();
        Rotating();
    }
    void Moving()
    {
        float translation = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0,translation,0);      
    }
    void Rotating()
    {
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime *-1f;
        transform.Rotate(0, 0, rotation);
    }
}
