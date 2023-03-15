using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float horizontalInput;
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        // Set HorizontalInput to recieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        //Moves Player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
