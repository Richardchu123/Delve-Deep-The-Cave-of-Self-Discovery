using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    


    public void playGame()
    {
        SceneManager.LoadSceneAsync(1);
    }


    public void exitGame()
    {
        Application.Quit();
    }
}