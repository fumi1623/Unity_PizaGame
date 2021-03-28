using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 10;
    private float spawnPosZ = 20;

    private float startDelay = 2;
    private float spawnInterval;
    

    // Start is called before the first frame update
    void Start()
    {
        spawnInterval = Random.Range(0.5f, 1.5f);
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal() {

        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        spawnInterval = 0;
        spawnInterval = Random.Range(0.5f, 1.5f);
    }
}
