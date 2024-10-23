using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    public float speed = 2.0f; // Vitesse de d�placement
    public Vector3 pointA; // Point de d�part
    public Vector3 pointB; // Point d'arriv�e

    private Vector3 target;

    void Start()
    {
        target = pointB;
    }

    void Update()
    {
        // D�place la cible d'un point � un autre
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // Si la cible atteint le point B, elle retourne au point A
        if (transform.position == pointB)
        {
            target = pointA;
        }
        else if (transform.position == pointA)
        {
            target = pointB;
        }
    }
}

