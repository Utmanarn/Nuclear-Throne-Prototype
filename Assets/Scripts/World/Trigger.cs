using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CircleCollider2D))]
public class Trigger : MonoBehaviour
{
    private CircleCollider2D collider;
    public UnityEvent onTrigger;
    
    [SerializeField] private GameObject specificTriggerObject = null;
    
    private void Awake()
    {
        collider = GetComponent<CircleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        onTrigger.Invoke();
    }
}
