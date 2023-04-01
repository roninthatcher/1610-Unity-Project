using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;

    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad); //Scene to Loag
        FindObjectOfType<AudioManager>().Play("Select");
        FindObjectOfType<AudioManager>().Play("Laser");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
        FindObjectOfType<AudioManager>().Play("Select");
    }
}
