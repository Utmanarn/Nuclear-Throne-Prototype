using System;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [SerializeField] private int bulletDamage = 1;
    [SerializeField] private float bulletSpeed = 560f;
    private float bulletLifeTime = 0f;
    [SerializeField] private float bulletMaxLifeTime = 4f;
    [SerializeField] private Rigidbody2D rb;

    private void Update()
    {
        bulletLifeTime += Time.deltaTime;
        if (bulletLifeTime > bulletMaxLifeTime)
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void UpdateForce(Vector2 dir)
    {
        rb.AddForce(dir * bulletSpeed);
    }

    private void OnTriggerEnter2D(Collider2D other) // BUG: Collides with the enemy trigger radius.
    {
        if (other.TryGetComponent(out Health health))
        {
            health.ReduceHealth(bulletDamage);
        }
    }
}
