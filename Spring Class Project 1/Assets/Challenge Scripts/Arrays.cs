using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public GameObject[] players;

    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("PLayer");

        for(int i =0; i < players.Length; i++)
        {
            Debug.log("Player number " + i + " is named " + players[i].name);
        }
    }
}
