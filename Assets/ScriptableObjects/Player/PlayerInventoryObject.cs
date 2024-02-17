using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerInventory", menuName = "ScriptableObjects/PlayerInventory")]
public class PlayerInventoryObject : ScriptableObject
{
    private List<string> heldGuns; // Use string names to reference what gun instances to spawn in the players hand.

    private void Awake()
    {
        heldGuns = new List<string>();
    }

    public void AddItem(string gun)
    {
        // Make sure the player only ever has 2 guns by dropping the held gun when picking up a 3rd gun.
        heldGuns.Add(gun);
    }

    private void SwapWeapon()
    {
        
    }
}
