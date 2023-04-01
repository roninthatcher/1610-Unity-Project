using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; // Array to store UFO ships
    public int ufoIndex;
    private float spawnPosX = 15f;
    private float SpawnPosZ = 15f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomUFO()
    {
        Vector3 spawnPOs = new Vector3(Random.Range(-spawnPosX, spawnPosX),0,SpawnPosZ);
        int ufoIndex = Random.Range(0, ufoPrefabs.Length); //Picks a random UFO from the Array
        Instantiate(ufoPrefabs[ufoIndex], spawnPOs, ufoPrefabs[ufoIndex].transform.rotation); //Spawns an indexed UFO from Array at a random position on the x axis
    }
}
