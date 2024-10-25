using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject difficultyMenu; 
    public GameObject mainMenu;
    public GameObject scoreMenu;
    public GameObject optionMenu;

    public void PlayGame()
    {
        difficultyMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void Score()
    {
        scoreMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void Option()
    {
        optionMenu.SetActive(true);
        mainMenu.SetActive(false);
    }


    public void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Pour arrêter le jeu dans l'éditeur
#endif
    }
}

