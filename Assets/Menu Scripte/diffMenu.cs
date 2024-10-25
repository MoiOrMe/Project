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
        LaunchGame(); // Si tu as une sc�ne d'entra�nement, ajoute la logique ici
    }

    public void Retour()
    {
        difficultyMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
