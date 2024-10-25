using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class diffMenu : MonoBehaviour
{
    public GameObject difficultyMenu;
    public GameObject mainMenu;

    private void LaunchGame()
    {
        // Charge la sc�ne principale
        SceneManager.LoadScene("MainMap");
    }

    public void Easy()
    {
        GameSettings.Difficulty = "Easy"; // Enregistre la difficult�
        LaunchGame();
    }

    public void Mid()
    {
        GameSettings.Difficulty = "Medium"; // Enregistre la difficult�
        LaunchGame();
    }

    public void Hard()
    {
        GameSettings.Difficulty = "Hard"; // Enregistre la difficult�
        LaunchGame();
    }

    public void Training()
    {
        GameSettings.Difficulty = "Training"; // D�finit la difficult� sur Training
        LaunchGame(); // Lance le jeu en mode entra�nement
    }

    public void Retour()
    {
        difficultyMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
