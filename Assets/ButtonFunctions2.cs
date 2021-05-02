using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions2 : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }
    public void LoadSinglePlayer()
    {
        SceneManager.LoadScene("GameSinglePlayer");
    }
    public void LoadMultiPLayer()
    {
        SceneManager.LoadScene("Game");
    }
}
