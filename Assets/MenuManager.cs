using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject difficultyMenu; // Assigner l'UI de sélection de difficulté ici

    public void PlayGame()
    {
        difficultyMenu.SetActive(true); // Affiche le menu de difficulté
    }

    public void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Pour arrêter le jeu dans l'éditeur
#endif
    }
}

