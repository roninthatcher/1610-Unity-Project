using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSpawn : MonoBehaviour
{
    public float verticalInput;
    public float SpawnPointY;
    public float SpawnPointx;
    public float speed;
    string itemName = "Gemstone";
    public GameObject[] pickupPrefabs; // Array to store UFO ships
    public int pickupIndex;
    private float spawnPosX = 20f;
    private float SpawnPosZ = 20f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;


    private void OnTriggerEnter3D(Collider collision)
    {
        //If player collides with Pick Up Item
        if (collision.tag == "Player")
        {
            //Destoys Pick Up Item
            Destroy(gameObject);
            //Writes out to indicate you have obtained the Pick Up Item
            Debug.Log(itemName + "has been collected!");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //Moves Pick Up Item down the screen
        transform.Translate(Vector3.down * Time.deltaTime * speed);

        //Bottom side wall, Items gets destoryed if it reaches the bottom
        if (transform.position.y < -SpawnPointY)
        {
            Destroy(gameObject);
        }
    }

    void SpawnRandomPos()
    {
        Vector3 spawnPOs = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, SpawnPosZ);
        int pickupIndex = Random.Range(0, pickupPrefabs.Length); //Picks a random Pick Up Item from the Array
        Instantiate(pickupPrefabs[pickupIndex], spawnPOs, pickupPrefabs[pickupIndex].transform.rotation); //Spawns an indexed Pick Up Item from Array at a random position on the x axis
    }
}
