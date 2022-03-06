using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuContrillScript : MonoBehaviour
{
    public GameObject Pause_ui;
    bool toggle;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            toggle = !toggle;
        }

        if(toggle == true)
        {
            Pause_ui.SetActive(true);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Pause_ui.SetActive(false);
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void CloseUI()
    {
        toggle = false;
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
