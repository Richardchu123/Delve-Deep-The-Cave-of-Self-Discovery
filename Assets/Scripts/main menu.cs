using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;


    public void playGame()
    {
        SceneManager.LoadScene("SampleScene");
    }


    public void exitGame()
    {
        Application.Quit();
    }
}