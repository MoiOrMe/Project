using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject difficultyMenu; // Assigner l'UI de s�lection de difficult� ici

    public void PlayGame()
    {
        difficultyMenu.SetActive(true); // Affiche le menu de difficult�
    }

    public void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Pour arr�ter le jeu dans l'�diteur
#endif
    }
}

