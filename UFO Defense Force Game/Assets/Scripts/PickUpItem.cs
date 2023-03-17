using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public float verticalInput;
    public float SpawnPointY;
    public float SpawnPointx;
    public float speed;

    private void OnTriggerEnter3D(Collider collision)
    {
        //If player collides with Pick Up Item
        if (collision.tag == "Player")
        {
            //Destoys Pick Up Item
            Destroy(gameObject);
            //Writes out to indicate you have obtained the Pick Up Item
            Debug.Log("You obtained a Key!");
        }
    }

    void Update()
    {
        //Moves Pick Up Item down the screen
        transform.Translate(Vector3.down * Time.deltaTime * speed);
        
        //Bottom side wall, Items respawns if it hits the walls
        if (transform.position.y < -SpawnPointY)
        {
            transform.position = new Vector3(SpawnPointx, -SpawnPointY, transform.position.z);
        }
        //Top side wall
        if (transform.position.y > SpawnPointY)
        {
            transform.position = new Vector3(SpawnPointx, SpawnPointY, transform.position.z);
        }
    }
}
