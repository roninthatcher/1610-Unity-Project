using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public int numberOfBombchusToCreate;
    public float speed = 3;
    public Vector3 destination;

    public void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
    }
}

