using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float lowerBounds = -30.0f;
    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Awake()
    {
        //Time.timescale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
            gameManager.isGameOver = true;
            FindObjectOfType<AudioManager>().Play("Game Over!");
        }
    }
}
