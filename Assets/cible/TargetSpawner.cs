using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject targetPrefab;  // La cible à instancier

    [SerializeField]
    private Vector3 spawnAreaSize = new Vector3(10, 10, 0);  // Taille de la zone de spawn (par exemple en X et Y)

    [SerializeField]
    private int targetCount = 5;  // Nombre de cibles à générer

    private void Start()
    {
        GenerateTargets();
    }

    private void GenerateTargets()
    {
        for (int i = 0; i < targetCount; i++)
        {
            Vector3 spawnPosition = GetRandomPositionInArea();

            // Définir l'orientation de chaque cible (par exemple, face vers l'avant en Z)
            Quaternion targetRotation = Quaternion.Euler(0, 0, 90);  // Remplace par d'autres valeurs si besoin

            Instantiate(targetPrefab, spawnPosition, targetRotation);
        }
    }

    private Vector3 GetRandomPositionInArea()
    {
        // Calcule une position aléatoire dans la zone définie
        float x = Random.Range(-spawnAreaSize.x / 2, spawnAreaSize.x / 2);
        float y = Random.Range(-spawnAreaSize.y / 2, spawnAreaSize.y / 2);
        float z = Random.Range(-spawnAreaSize.z / 2, spawnAreaSize.z / 2);

        // Ajuste la position avec le transform du spawner
        return transform.position + new Vector3(x, y, z);
    }
}
