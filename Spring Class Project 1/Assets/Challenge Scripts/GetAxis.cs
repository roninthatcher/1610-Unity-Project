using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AxisExample : MonoBehaviour
{
    public float range;
    public Text textOutput;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Retirned: " + h.ToString("F2");
    }
}

public class AxisRawExample : MonoBehaviour
{
    public float range;
    public Text textOutput;

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Retirned: " + h.ToString("F2");
    }
}

public class DualAxisExample : MonoBehaviour
{
    public Text horizontalValueDisplayText;
    public Text verticalValueDisplayText;
    public float hRange;
    public float vRange;

    transform.position = new Vector3(xPos, 0, vPos);
    horizontalValueDisplayText.text = h.ToString("F2");
    verticalValueDisplayText.text = v.ToString("F2");
}