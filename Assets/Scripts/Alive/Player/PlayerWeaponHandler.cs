using UnityEngine;

public class PlayerWeaponHandler : MonoBehaviour
{
    [SerializeField] private PlayerInventoryObject inventory;
    private BaseGun equippedWeapon;

    private void OnEnable()
    {
        if (equippedWeapon) return;
        equippedWeapon = GetComponentInChildren<BaseGun>();
    }

    private void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Mouse0)) return;
        if (equippedWeapon)
            equippedWeapon.Shoot();
    }

    public void PickUpGun(string gun)
    {
        inventory.AddItem(gun);
    }
}
