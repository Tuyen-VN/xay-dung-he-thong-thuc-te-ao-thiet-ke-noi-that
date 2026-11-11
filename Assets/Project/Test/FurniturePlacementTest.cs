
using UnityEngine;

public class FurniturePlacementTest : MonoBehaviour
{
    [System.Serializable]
    public class PlacementEntry
    {
        public string entryName;

        [Header("Slot")]
        public FurnitureSlot slot;

        [Header("Furniture")]
        public FurnitureData furnitureData;
    }

    [Header("Placement Entries")]
    public PlacementEntry[] placements;

    [Header("Test Settings")]
    public bool placeOnStart = false;

    private void Start()
    {
        if (placeOnStart)
        {
            PlaceAllFurniture();
        }
    }

    [ContextMenu("Run Furniture Placement Test")]
    public void PlaceAllFurniture()
    {
        foreach (PlacementEntry entry in placements)
        {
            PlaceFurniture(entry);
        }
    }

    private void PlaceFurniture(PlacementEntry entry)
    {
        if (entry == null || entry.slot == null ||
            entry.furnitureData == null)
        {
            Debug.LogWarning("Missing Slot or FurnitureData.");
            return;
        }

        FurnitureSlot slot = entry.slot;
        FurnitureData furniture = entry.furnitureData;

        // Check occupied state
        if (slot.isOccupied)
        {
            Debug.LogWarning(
                slot.slotId + " is already occupied."
            );
            return;
        }

        // Check furniture category
        if (furniture.category != slot.allowedCategory)
        {
            Debug.LogWarning(
                furniture.furnitureName +
                " does not match " + slot.slotId
            );
            return;
        }

        // Check prefab
        if (furniture.furniturePrefab == null)
        {
            Debug.LogWarning(
                furniture.furnitureName + " has no Prefab."
            );
            return;
        }

        // Check dimensions
        if (furniture.width > slot.maxWidth ||
            furniture.depth > slot.maxDepth)
        {
            Debug.LogWarning(
                furniture.furnitureName +
                " exceeds the dimensions of " + slot.slotId
            );
            return;
        }

        // Create furniture at SlotMarker
        GameObject furnitureObject = Instantiate(
            furniture.furniturePrefab,
            slot.transform.position,
            slot.transform.rotation
        );

        furnitureObject.name = furniture.furnitureName;

        // Parent furniture to room root
        furnitureObject.transform.SetParent(
            slot.transform.root,
            true
        );

        // Update slot state
        slot.isOccupied = true;

        Debug.Log(
            "Successfully placed " +
            furniture.furnitureName +
            " at " + slot.slotId
        );
    }
}
