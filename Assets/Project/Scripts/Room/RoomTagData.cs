
using UnityEngine;

[CreateAssetMenu(
    fileName = "NewRoomTag",
    menuName = "InteriorVR/Room Tag"
)]
public class RoomTagData : ScriptableObject
{
    [Header("Tag Information")]
    public string tagId;
    public string tagName;

    [Header("Classification")]
    public string tagGroup;

    [TextArea]
    public string description;
}
