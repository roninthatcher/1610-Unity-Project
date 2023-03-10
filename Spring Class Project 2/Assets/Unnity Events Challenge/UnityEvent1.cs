using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEvent1 : MonoBehaviour
{
    UnityEvent SaveProgress;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SaveProgress.Invoke();
        }
    }

    void Save()
    {
        Debug.Log("Save Complete");
    }
}
