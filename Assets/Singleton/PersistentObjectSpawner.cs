using UnityEngine;

public class PersistentObjectSpawner : MonoBehaviour
{
    // CONFIG DATA
    [Tooltip("This prefab will only be spawned once and persisted between " +
    "scenes.")]
    [SerializeField] GameObject persistenObjectPrefab;

    // PRIVATE STATE
    static bool hasSpawned;

    // PRIVATE
    private void Awake()
    {
        if (hasSpawned) return;

        SpawnedPersistentObjects();

        hasSpawned = true;
    }
    void SpawnedPersistentObjects()
    {
        GameObject persistentObject = Instantiate(persistenObjectPrefab);
        DontDestroyOnLoad(persistentObject); 
    }

}
