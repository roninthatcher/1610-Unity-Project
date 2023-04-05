using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Text))]
public class TextLabelBehaviour : MonoBehaviour
{
    private Text label;
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
