public class TargetMovement : MonoBehaviour
{
    public float speed = 2.0f; // Vitesse de déplacement
    public Vector3 pointA; // Point de départ
    public Vector3 pointB; // Point d'arrivée

    private Vector3 target;

    void Start()
    {
        target = pointB;
    }

    void Update()
    {
        // Déplace la cible d'un point à un autre
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
