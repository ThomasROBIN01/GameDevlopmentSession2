using System.Collections.Generic;
using UnityEngine;


public class Weapon : Item  // this is a script child of Item, so can pick elements from the Item script
{
    private Item.ItemType itemType = ItemType.weapon;
    
    private float damage;

    public enum DamageType { normal, fire, ice };

    public DamageType damageType = DamageType.normal;

    public float durability { get; private set; }

    public Dictionary<string, string> animations = new Dictionary<string, string>
    {
        {"attackAnim", "default" },
        {"blockAnim", "default" },
        {"parryAnim", "default" }
    };

    public string hudModel;

    public Weapon(string _itemName, Item.ItemType _itemType, string _spriteID, float _damage, DamageType _damageType, float _durability, string _attackAnim, string _blockAnim, string _parryAnim, string _meshID)
    {
        itemName = _itemName;
        itemType = _itemType;

        foreach (Sprite s in ItemValueManager.Instance.sprites)
        {
            if (s.name == _spriteID)
            {
                uiDisplaySprite = s;
            }
        }

        damage = _damage;
        damageType = _damageType;
        durability = _durability;
        animations["attackAnim"] = _attackAnim;
        animations["blockAnim"] = _blockAnim;
        animations["parryAnim"] = _parryAnim;
        hudModel = _meshID;

    }



    // private enum WeaponType { sword, dagger, bow }

    public ItemType GetItemType()
    {
        return itemType;
    }

    public float GetDamage()
    {
        return damage;
    }

    public DamageType GetDamageType()
    {
        return damageType;
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
