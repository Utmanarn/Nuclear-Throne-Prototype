using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int currentHealth = 3;

    public void ReduceHealth(int damage)
    {
        Debug.Log("Health Reduced.");
        currentHealth -= damage;
        if (currentHealth <= 0)
            OnDeath();
    }

    private void OnDeath()
    {
        Debug.Log("OnDeath called"); // DEBUGGING //
        // Do the die
    }
}
