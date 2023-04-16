using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
public class TransformBehaviour : MonoBehaviour
{
    public ID idObj;
    private SpriteRenderer rendererObj;

    public void ResetToZero()
    {
        transform.position = Vector3.zero;
    }

    public void ChangeRendererColor(ColorID idObj)
    {
        rendererObj = GetComponent<SpriteRenderer>();
        rendererObj.color = idObj.value;
    }
}
