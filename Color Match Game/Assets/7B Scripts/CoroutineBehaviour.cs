using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineBehaviour : MonoBehaviour
{
    public bool canRun = true;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;

    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        Debug.Log("Start");
        yield return wfsObj;
        Debug.Log("Late Start");

        while (true)
        {
            yield return wfsObj;
            Debug.Log("Run on Start");
        }
    }
}
