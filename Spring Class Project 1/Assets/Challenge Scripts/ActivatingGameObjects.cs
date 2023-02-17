using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatingGameObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.SetActive(false);
    }
}

public class CheckState : MonoBehaviour
{
    public GameObject myObject;

    void Start ()
    {
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
    }
}