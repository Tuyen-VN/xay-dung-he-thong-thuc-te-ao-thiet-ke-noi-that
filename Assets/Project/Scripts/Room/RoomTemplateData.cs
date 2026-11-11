
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
    fileName = "NewRoomTemplateData",
    menuName = "InteriorVR/Room Template Data"
)]
public class RoomTemplateData : ScriptableObject
{
    [Header("Room Information")]
    public string roomId;
    public string roomName;

    [Header("Room Prefab")]
    public GameObject roomPrefab;

    [Header("Room Tags")]
    public List<RoomTagData> roomTags = new List<RoomTagData>();
}
