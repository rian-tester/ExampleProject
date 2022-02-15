using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheGun : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            projectilePrefab.transform.position = transform.position;
            Instantiate(projectilePrefab);
        }
    }
}
