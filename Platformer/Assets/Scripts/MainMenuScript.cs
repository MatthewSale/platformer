using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    public GameObject Normal_UI;
    public GameObject Crediuts;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Portal");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void OpenCredits()
    {
        Normal_UI.SetActive(false);
        Crediuts.SetActive(true);
    }

    public void CloseCredits()
    {
        Normal_UI.SetActive(true);
        Crediuts.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
