using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class GridManager : MonoBehaviour
{
    [SerializeField] private List<Image> gridCellLocations = new List<Image>();

    [SerializeField] private List<InventoryItemSprite> inventoryItemSprites = new List<InventoryItemSprite>();  // InventoryItemSprite is another script we have created

    [SerializeField] private GameObject prefabItemSprite;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int gridNameIndex = 0;

        // iterate through all child objects
        foreach (Transform child in transform)
        {
            if(child.TryGetComponent<Image>(out Image image))   // check if the child has an Image, and if so, it returns the image (thanks to out)
            {
                gridCellLocations.Add(image);
                child.name = "GridCell (" + gridNameIndex + ")";
                gridNameIndex++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ItemPickupAddSpriteToInventoryGrid(Item item)
    {
        Image firstEmptyGridCell = null;

        foreach(Image image in gridCellLocations)
        {
            if(image.gameObject.transform.childCount == 0)
            {
                firstEmptyGridCell = image;
                break;
            }
        }

        if(firstEmptyGridCell != null)
        {
            GameObject newSprite = Instantiate(prefabItemSprite, firstEmptyGridCell.gameObject.transform);  // We specify firstEmptyGridCell.gameObject.transform as parent of prefabItemSprite

            newSprite.name = item.itemName + "_sprite";

            if (newSprite.TryGetComponent<Image>(out Image newSpriteImage))
            {
                newSpriteImage.sprite = item.uiDisplaySprite;
                newSpriteImage.rectTransform.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
            }
        }
        else
        {
            Debug.Log("Inventory is full, you need to remove some objects");
        }

    }

    public void RemoveOldestItemCollectedFromInventory()
    {
        Destroy(gridCellLocations[0].gameObject);
    }
}
