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

    public void GetSelectedItem()
    {
        Item receivedItem = inventoryManager.GetSelectedItem(false);
        if (receivedItem != null)
        {
            Debug.Log("recived item" + receivedItem);
        }
        else
        {
            Debug.Log("No item recived");
        }
    }

    public void UseSelectedItem()
    {
        Item receivedItem = inventoryManager.GetSelectedItem(true);
        if (receivedItem != null)
        {
            Debug.Log("Used item" + receivedItem);
        }
        else
        {
            Debug.Log("No item used");
        }
    }
}
