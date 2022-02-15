using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Pool;

public class TheGun : MonoBehaviour
{
    [SerializeField] Vector3 offset;
    [SerializeField] TheProjectile projectilePrefab;

    private IObjectPool<TheProjectile> projectilePool;

    private void Awake()
    {
        projectilePool = new ObjectPool<TheProjectile>
            (
            CreateProjectile,
            OnGet,
            Onrelease
            );
    }

    private void OnGet(TheProjectile theProjectile)
    {
        theProjectile.gameObject.SetActive(true);
        theProjectile.transform.position = transform.position + offset;
    }

    private void Onrelease(TheProjectile theProjectile)
    {
        theProjectile.gameObject.SetActive(false);
    }

    private TheProjectile CreateProjectile()
    {
        TheProjectile instance = Instantiate(projectilePrefab);
        instance.SetPool(projectilePool);
        return instance;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            projectilePool.Get();       
        }
        Debug.Log($"Inactive : {projectilePool.CountInactive}, Active : ");
    }
}
