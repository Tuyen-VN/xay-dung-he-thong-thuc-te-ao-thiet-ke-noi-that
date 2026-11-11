
using UnityEngine;

public enum FurnitureCategory
{
    Bed,
    Wardrobe,
    Desk,
    Chair,
    Sofa,
    Table,
    Cabinet
}

public enum FurnitureStyle
{
    Modern,
    Minimalist,
    Classic,
    Scandinavian,
    Industrial
}

public enum FurnitureMaterial
{
    Wood,
    Metal,
    Glass,
    Fabric,
    Leather,
    Plastic
}

public enum FurnitureColor
{
    White,
    Black,
    Brown,
    Gray,
    Beige,
    Blue,
    Green
}

[CreateAssetMenu(
    fileName = "NewFurnitureData",
    menuName = "InteriorVR/Furniture Data"
)]
public class FurnitureData : ScriptableObject
{
    [Header("Basic Information")]
    public string furnitureId;
    public string furnitureName;

    [Header("Classification")]
    public FurnitureCategory category;
    public FurnitureStyle[] styles;
    public FurnitureMaterial[] materials;
    public FurnitureColor[] colors;

    [Header("Dimensions (Meters)")]
    public float width;
    public float depth;
    public float height;

    [Header("Prefab Reference")]
    public GameObject furniturePrefab;
}
