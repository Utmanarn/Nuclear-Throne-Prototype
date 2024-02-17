using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private bool playerInRange;
    
    [Header("Movement Behaviour")]
    [SerializeField] private Transform target;
    [SerializeField] private float movementSpeed = 5f;
    [SerializeField] private float detectionRadius = 12f;
    [SerializeField] private float keepDistance = 5f;

    [Header("Detection Drawing")] 
    [SerializeField] private bool drawDetectionRadius;
    [SerializeField] private bool drawKeepDistance;

    private void Start()
    {
        if (rb == null)
            rb = GetComponent<Rigidbody2D>();
        if (target == null) 
            target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        CheckForPlayer();
        
        if (playerInRange)
            EngagePlayer();
        else
            Patrol();
    }

    private void CheckForPlayer()
    {
        if (Vector2.Distance(transform.position, target.position) <= detectionRadius)
            playerInRange = true;
        else
            playerInRange = false;
    }

    private void EngagePlayer() // TODO: Finish working on the movement.
    {
        if (Vector2.Distance(transform.position, target.position) >= keepDistance)
            rb.transform.position = Vector2.MoveTowards(transform.position, target.position, movementSpeed * Time.deltaTime);
        // Could be made to circle the player with an else statement to avoid stationary enemies.
    }

    private void Patrol() // Implement patrol behaviour
    {
        
    }

    private void OnDrawGizmos()
    {
        if (drawDetectionRadius)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, detectionRadius);
        }

        if (drawKeepDistance)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawWireSphere(transform.position, keepDistance);
        }
    }
}
