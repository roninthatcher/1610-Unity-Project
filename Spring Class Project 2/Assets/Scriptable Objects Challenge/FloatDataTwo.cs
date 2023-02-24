using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[CreateAssetMenu]
public class FloatDataTwo : ScriptableObject
{
    public UnityEvent onZeroEvent;

    public float value;

    public void UpdateValue(float number)
    {
        value += number;
    }

    public void ReplaceValue(float number)
    {
        value = number;
    }

    public void DisplayImage(Image img)
    {
        if (value <= 0)
        {
            onZeroEvent.Invoke();
        } else if (value >= 1)
        {
            value = 1;
        }

        img.fillAmount = value;
    }

    public void DisplayNumber(Text txt)
    {
        txt.text = value.ToString();
    }
}
