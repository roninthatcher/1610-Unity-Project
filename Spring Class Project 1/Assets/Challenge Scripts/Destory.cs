using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryBasic : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destory(gameObject);
        }
    }
}

public class DestoryOther : MonoBehaviour
{
    public GameObject other;

    void Update()
    {
        if(Input.GetKay(KeyCode.Space))
        {
            Destory(other);
        }
    }
}

public class DestoryCompenent : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKay(KeyCode.Space))
        {
            Destory(GetComponent<MeshRenderer>());
        }
    }
}