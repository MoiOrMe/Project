using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    public float moveDistance = 5.0f;    // Distance totale de déplacement

    private Vector3 startPosition;       // Position de départ

    void Start()
    {
        // Enregistrer la position initiale
        startPosition = transform.position;

        // Appliquer la taille définie en fonction de la difficulté
        Vector3 targetSize = GameSettings.TargetSize;
        transform.localScale = new Vector3(targetSize.x, 0.001f, targetSize.z); // Taille fixée à 0.001 en Y
    }

    void Update()
    {
        // Si c'est le mode d'entraînement, ne pas bouger
        if (GameSettings.Difficulty == "Training") return;

        // Mouvement oscillant de l'avant vers l'arrière (axe Z)
        float speed = GameSettings.TargetSpeed; // Récupère la vitesse en fonction de la difficulté
        float offset = Mathf.PingPong(Time.time * speed, moveDistance) - (moveDistance / 2);
        transform.position = startPosition + new Vector3(0, 0, offset);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Vérifie si la cible est touchée par un objet avec un tag spécifique, par exemple "Projectile"
        if (collision.gameObject.CompareTag("Arrow"))
        {
            // Détruit la cible lorsqu'elle est touchée par un projectile
            Destroy(gameObject);
        }
    }
}
