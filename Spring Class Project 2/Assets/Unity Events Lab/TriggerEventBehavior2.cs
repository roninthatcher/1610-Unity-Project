using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehaviour2 : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}