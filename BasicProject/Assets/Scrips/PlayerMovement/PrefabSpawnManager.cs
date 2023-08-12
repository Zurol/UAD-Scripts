using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PrefabSpawnManager : MonoBehaviour
{
    public GameObject prefabToSpawn;   // The prefab to be spawned
    public Transform[] spawnPoints;    // Array of spawn points
    public float spawnInterval = 3f;    // Time interval between spawns
    public int spawnLimit = 10;         // Maximum number of spawned instances

    private int spawnedCount = 0;       // Number of spawned instances
    private float spawnTimer = 0f;

    private void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnedCount < spawnLimit && spawnTimer >= spawnInterval)
        {
            SpawnPrefab();
            spawnTimer = 0f;
        }
    }

    private void SpawnPrefab()
    {
        if (spawnPoints.Length == 0)
        {
            return; // No spawn points, do nothing
        }

        // Choose a random spawn point index
        int randomIndex = Random.Range(0, spawnPoints.Length);

        // Instantiate the prefab at the chosen spawn point
        Instantiate(prefabToSpawn, spawnPoints[randomIndex].position, Quaternion.identity);

        // Increment the spawned count
        spawnedCount++;
    }
}
