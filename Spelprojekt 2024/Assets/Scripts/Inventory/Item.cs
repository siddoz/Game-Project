using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Scriptable object/Item")]
public class Item : ScriptableObject
{
    [Header("Only gameplay")]
    public TileBase tile;
    public ItemType type;
    public ActionType actionType;
    public Vector2Int raneg = new Vector2Int(5, 4);

    [Header("Only UI")]
    public bool stackable = true;

    [Header("Both")]
    public Sprite image;
}

public enum ItemType
{
    BuildingBlock,
    Tool
}

public enum ActionType
{
    Hugga,
    Mine,
    Attack
        //ÄNDRA DEM HÄR, det ska vara allt vi får resurser av. SÅ typ attacken ska skicka hit resurerna samma med hugga trä, med mera
}