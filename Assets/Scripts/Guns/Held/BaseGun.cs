using UnityEngine;

public class BaseGun : MonoBehaviour
{
    [SerializeField] protected Ammo ammo;
    [SerializeField] protected GameObject bulletTemplate;
    [SerializeField] protected float fireRate;
    [SerializeField] protected float reloadTime;

    public virtual void Shoot()
    {
        
    }
}
