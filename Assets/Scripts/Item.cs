using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Item : MonoBehaviour
{
    public enum ItemType { sword, shield, healpot, stampot, gem}
    public ItemType itemType;

    [SerializeField] List<Sprite> uiDisplaySprites = new List<Sprite>();

    public Sprite uiDisplaySprite;

    public string itemName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        uiDisplaySprite = uiDisplaySprites[(int)itemType];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
