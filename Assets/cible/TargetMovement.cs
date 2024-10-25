using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    public float moveDistance = 5.0f;    // Distance totale de d�placement

    private Vector3 startPosition;       // Position de d�part

    void Start()
    {
        // Enregistrer la position initiale
        startPosition = transform.position;

        // Appliquer la taille d�finie en fonction de la difficult�
        Vector3 targetSize = GameSettings.TargetSize;
        transform.localScale = new Vector3(targetSize.x, 0.001f, targetSize.z); // Taille fix�e � 0.001 en Y
    }

    void Update()
    {
        // Si c'est le mode d'entra�nement, ne pas bouger
        if (GameSettings.Difficulty == "Training") return;

        // Mouvement oscillant de l'avant vers l'arri�re (axe Z)
        float speed = GameSettings.TargetSpeed; // R�cup�re la vitesse en fonction de la difficult�
        float offset = Mathf.PingPong(Time.time * speed, moveDistance) - (moveDistance / 2);
        transform.position = startPosition + new Vector3(0, 0, offset);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // V�rifie si la cible est touch�e par un objet avec un tag sp�cifique, par exemple "Projectile"
        if (collision.gameObject.CompareTag("Arrow"))
        {
            // D�truit la cible lorsqu'elle est touch�e par un projectile
            Destroy(gameObject);
        }
    }
}
