using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public ScoreManager scoreManager; //Store reference to score manager
    public int scoreToGive;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive); //Increase the Score
        Destroy(gameObject); //Destory this game object
        Destroy(other.gameObject); //Destory other game object it hits
        FindObjectOfType<AudioManager>().Play("Explosion");
    }
}
