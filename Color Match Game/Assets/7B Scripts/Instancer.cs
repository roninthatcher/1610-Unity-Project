using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num;

    public void CreateInstance(GameObject obj)
    {
        Instantiate(obj);
    }

    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.Identity);
    }

    public void CreateInstanceFromList(Vector3DataList obj)
    {
        for (var i = 0; i < obj.vector3DList.Count; i++)
        {
            Instantiate(prefab, obj.vector3DList[0].value, Quaternion.Identity);
        }
    }

    public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
        Instantiate(prefab, obj.vector3DList[0].value, Quaternion.Identity);
        num++;
        if (num == obj.vector3DList.Count)
        {
            num = 0;
        }
    }

    public void CreateInstanceListRandomly(Vector3DataList obj)
    {
        num = Random.Range(0, obj.vector3DList.Count - 1);
        Instantiate(prefab, obj.vector3DList[0].value, Quaternion.Identity);
    }
}
