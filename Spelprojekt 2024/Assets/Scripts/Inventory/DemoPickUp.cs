using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoPickUp : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public Item[] itempickup;

    public void PickUpItem(int id)
    {
        bool result = inventoryManager.AddItem(itempickup[id]);
        if (result == true)
        {
            Debug.Log("Item Added");
        }
        else
        {
            Debug.Log("ITEM NOT ADDED");
        }
    }
}
