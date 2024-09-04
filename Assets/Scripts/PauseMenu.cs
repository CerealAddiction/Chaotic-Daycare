using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    private bool _isPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || (Input.GetKeyDown(KeyCode.P)) && !_isPaused)
        {
            Pause();
        }
    }

    private void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
        _isPaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
    public void Continue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
        _isPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

}

