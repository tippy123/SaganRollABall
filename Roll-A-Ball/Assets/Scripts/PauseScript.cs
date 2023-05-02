using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PauseScript : MonoBehaviour
{
    public GameObject pausePanel;
    public bool isPaused = false;

    void Start()
    {
        pausePanel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    private void TogglePause()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            pausePanel.SetActive(true); 
        }
        else
        {
            pausePanel.SetActive(false);
        }
           
    }
}
