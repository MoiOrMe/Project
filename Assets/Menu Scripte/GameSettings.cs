using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameSettings
{
    public static string Difficulty { get; set; } = "Easy"; // Valeur par défaut

    // Ajoute une propriété pour la taille des cibles
    public static Vector3 TargetSize
    {
        get
        {
            switch (Difficulty)
            {
                case "Easy":
                    return new Vector3(2.0f, 0.001f, 2.0f); // Taille en X et Z pour facile
                case "Medium":
                    return new Vector3(1.5f, 0.001f, 1.5f); // Taille en X et Z pour moyen
                case "Hard":
                    return new Vector3(1.0f, 0.001f, 1.0f); // Taille en X et Z pour difficile
                case "Training":
                    return new Vector3(5.0f, 0.001f, 5.0f); // Taille x5 en X et Z pour l'entraînement
                default:
                    return new Vector3(2.0f, 0.001f, 2.0f); // Taille par défaut
            }
        }
    }

    // Ajoute une propriété pour la vitesse des cibles
    public static float TargetSpeed
    {
        get
        {
            switch (Difficulty)
            {
                case "Easy":
                    return 2.0f; // Vitesse pour facile
                case "Medium":
                    return 5.0f; // Vitesse pour moyen
                case "Hard":
                    return 7.5f; // Vitesse pour difficile
                case "Training":
                    return 0f; // Pas de mouvement en mode entraînement
                default:
                    return 2.0f; // Vitesse par défaut
            }
        }
    }
}
