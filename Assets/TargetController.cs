public class TargetController : MonoBehaviour
{
    public enum DifficultyLevel { Easy, Normal, Hard }
    public DifficultyLevel currentLevel;

    public GameObject target; // Le prefab de la cible
    public float easySpeed = 1f;
    public float normalSpeed = 3f;
    public float hardSpeed = 5f;

    public Vector3 easySize = new Vector3(2, 2, 2);  // Taille pour facile
    public Vector3 normalSize = new Vector3(1, 1, 1); // Taille pour normal
    public Vector3 hardSize = new Vector3(0.5f, 0.5f, 0.5f); // Taille pour difficile

    void Start()
    {
        AdjustTargetBasedOnLevel();
    }

    void AdjustTargetBasedOnLevel()
    {
        switch (currentLevel)
        {
            case DifficultyLevel.Easy:
                target.transform.localScale = easySize; // Augmente la taille de la cible
                target.GetComponent<TargetMovement>().speed = easySpeed; // Diminue la vitesse de déplacement
                break;

            case DifficultyLevel.Normal:
                target.transform.localScale = normalSize;
                target.GetComponent<TargetMovement>().speed = normalSpeed;
                break;

            case DifficultyLevel.Hard:
                target.transform.localScale = hardSize; // Réduit la taille de la cible
                target.GetComponent<TargetMovement>().speed = hardSpeed; // Augmente la vitesse de déplacement
                break;
        }
    }
}
