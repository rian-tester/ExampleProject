using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMonoSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] prefabs;

    static bool hasSpawned = false;
    private void Awake()
    {
        if (hasSpawned) return;

        SpawningPrefab();

        hasSpawned = true;
    }

    private void SpawningPrefab()
    {
        foreach(var prefab in prefabs)
        {
           GameObject spawnedPrefab = Instantiate(prefab);
            DontDestroyOnLoad(spawnedPrefab);
        }
    }
}
