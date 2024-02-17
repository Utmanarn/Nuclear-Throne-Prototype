using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class PistolGround : MonoBehaviour
{
    private Collider2D coll;

    private void OnEnable()
    {
        coll = GetComponent<Collider2D>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.TryGetComponent(out PlayerWeaponHandler weaponHandler))
        {
            if (!Input.GetKeyDown(KeyCode.E)) return;
            weaponHandler.PickUpGun("pistol");
            Destroy(gameObject);
            Debug.Log("Gun picked up.");
        }
    }
}
