using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instaniate : MonoBehaviour
{
    public Rigibody rocketPrefab;
    public Transform barrelEnd;

    void Update()
    {
       if(Inpur.GetButtonDown("Fire1"))
        {
            Rigidbody rocketInstance;
            rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            rocketInstance.AddForce(barrelEnd.forward * 5000);
        }
    }
}

public class RocketDestruction : Monobehaviour
{
    void Start()
    {
        Destroy(gameObject, 1.5f);
    }
}