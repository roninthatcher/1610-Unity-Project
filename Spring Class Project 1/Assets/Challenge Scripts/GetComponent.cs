using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponent : MonoBehaviour
{
    public GameObject otherGameObject;

    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider baxCol;
    
    void Awake()
    {
        anotherScript = GetComponent<anotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<yetAnotherScript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }

    void Start()
    {
        boxCol.size = new Vector3(3, 3, 3);
        Debug.Log("Theplayer's score is " + anotherScript.playerScore);
        Debug.Log("The player had died " + yetAnotherScript.numberOfPlayerDeaths + "times");
    }
}

public class AnotherScript : Monobehaviour
{
    public int playerScore = 9001;
}

public class YetAnotherScript : MonoBehaviour
{
    public int numberOfPlayerDeaths = 3;
}