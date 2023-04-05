using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DragableBehaviour : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    public Vector3 position, offset;
    public UnityEvent startDragEvent, endDragEvent;

    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        draggable = true;
        startDragEvent.Invoke();
        yield return new WaitForFixedUpdate();

        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToViewPoint(Input.mousePosition) + offset;
            transform.position = position;
        }

        private void OnMouseUp()
        {
            draggable = false;
            endDragEvent.Invoke();
        }
    }
}
