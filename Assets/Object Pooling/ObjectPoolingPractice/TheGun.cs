using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Pool;

public class TheGun : MonoBehaviour
{
    [SerializeField] TheProjectile projectilePrefab;

    private IObjectPool<TheProjectile> projectilePool;

    private void Awake()
    {
        projectilePool = new ObjectPool<TheProjectile>(CreateProjectile);
    }

    private TheProjectile CreateProjectile()
    {
        return Instantiate(projectilePrefab);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            projectilePool.Get();       
        }
    }
}
