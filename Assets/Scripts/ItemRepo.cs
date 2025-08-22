using UnityEngine;
using System.Collections.Generic;

public class ItemRepo : MonoBehaviour
{
    public static ItemRepo Instance;

    List<Weapon> weaponLibrary = new List<Weapon>
    {
        new Weapon("Sword od Damocles", Item.ItemType.weapon, "Sword", 420, Weapon.DamageType.normal, 100, "sword_attacking", "sword_blocking_1", "sword_parry_1", "sword_damocles_mesh"),
        
        // new Weapon("PigSticker", Item.ItemType.weapon, "Sword", 420, Weapon.DamageType.normal, 100, "sword_attacking", "sword_blocking_1", "sword_parry_1", "sword_damocles_mesh"),

    };

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("You can only have one object with ItemRepo attached to it");
            gameObject.SetActive(false);
        }
    }
}
