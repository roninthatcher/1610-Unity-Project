using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEvent3 : MonoBehaviour
{
    public UnityEvent gameStart;
    public UnityEvent gameOver;
    public UnityEvent scoreRecorded;
    bool isPlaying = false;

    private void Update()
    {
        if(isPlaying == false)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                isPlaying = true;
                StartGame();
            }
        }
    }

    public void StartGame()
    {
        gameStart?.Invoke();
    }

    public void LoseGame()
    {
        isPlaying = false;
        gameOver?.Invoke();
    }

    public void RecordScore()
    {
        scoreRecorded?.Invoke();
    }
}
