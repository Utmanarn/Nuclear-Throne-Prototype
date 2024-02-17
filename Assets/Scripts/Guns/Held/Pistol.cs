using UnityEngine;

public class Pistol : BaseGun
{
    private void OnPickup()
    {
        ammo = GetComponentInParent<Ammo>();
    }
    
    public override void Shoot()
    {
        var bullet = Instantiate(bulletTemplate, transform.position, transform.rotation); // TODO: Make sure bulletTemplate is not null here.
        BulletBehaviour bulletBehaviour = bullet.GetComponent<BulletBehaviour>();
        bulletBehaviour.UpdateForce(-transform.up);
    }
}
