using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(idObj);
    }
}
