using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); //Destory this game object
        Destroy(other.gameObject); //Destory other game object it hits
    }
}
