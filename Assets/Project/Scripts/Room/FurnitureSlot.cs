
using UnityEngine;

public class FurnitureSlot : MonoBehaviour
{
    [Header("Slot Information")]
    public string slotId;

    [Header("Allowed Furniture")]
    public FurnitureCategory allowedCategory;

    [Header("Slot Dimensions (Meters)")]
    public float maxWidth;
    public float maxDepth;

    [Header("Slot State")]
    public bool isOccupied;
}
