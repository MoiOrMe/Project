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
        // Charge la scène principale
        SceneManager.LoadScene("MainMap");
    }

    public void Easy()
    {
        GameSettings.Difficulty = "Easy"; // Enregistre la difficulté
        LaunchGame();
    }

    public void Mid()
    {
        GameSettings.Difficulty = "Medium"; // Enregistre la difficulté
        LaunchGame();
    }

    public void Hard()
    {
        GameSettings.Difficulty = "Hard"; // Enregistre la difficulté
        LaunchGame();
    }

    public void Training()
    {
        GameSettings.Difficulty = "Training"; // Définit la difficulté sur Training
        LaunchGame(); // Lance le jeu en mode entraînement
    }

    public void Retour()
    {
        difficultyMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
