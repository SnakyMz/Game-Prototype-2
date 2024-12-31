using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnPositionZ = 25.0f;
    public float spawnRangeX = 15.0f;
    public float spawnStartDelay = 2.0f;
    public float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnStartDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        // Generating random animal selection
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // Generating random animal position
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX + 1), 0, spawnPositionZ);

        // Spawning random animals
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
