using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

[RequireComponent(typeof(text))]
public class TextLabelBehaviour : MonoBehaviour
{
    private text label;
    public UnityEvent startEvent;

    private void Start()
    {
        label = GetComponent<TextLabelBehaviour>();
        startEvent.Invoke();
    }

    public void UpdateLabel(FloatData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InariantCulture);
    }

    public void UpdateLabel(IntData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InariantCulture);
    }
}
