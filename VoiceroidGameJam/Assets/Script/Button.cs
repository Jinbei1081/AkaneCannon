using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    Text text;

    bool isMenu;

    public void Start()
    {
        text = GetComponentInChildren<Text>();
    }

    public void ResetPos()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("gameScene");
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void menuButton()
    {
        isMenu = !isMenu;
        if (isMenu)
        {
            text.text = "←";
            SceneManager.LoadScene("PauseUI", LoadSceneMode.Additive);
            Time.timeScale = 0;
        }
        else
        {
            text.text = "Menu";
            SceneManager.UnloadSceneAsync("PauseUI");
            Time.timeScale = 1;
        }
    }

    public void toTitle()
    {
        SceneManager.LoadScene("titleScene");
    }
}
