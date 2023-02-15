using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptOne : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
       if (Input.GeyKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
       if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
       if (Input.GetKeyDown(KeyCode.B))
        {
            GetCompenent<Renderer>().material.color = Color.blue;
        }
    }
}
