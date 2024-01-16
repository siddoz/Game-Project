using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public int Maxstackeditems = 30;
    public InventorySlot[] InventorySlots;
    public GameObject InventoryItemPrefab;

    int selectedSlot = -1;

    public void Start()
    {
        ChangedselectedSlot(0);
    }

    void ChangedselectedSlot(int newValue)
    {
        if (selectedSlot >= 0)
        {
            InventorySlots[selectedSlot].Deselect();
        }
        InventorySlots[newValue].Select();
        selectedSlot = newValue;
    }

    public bool AddItem(Item item)
    {
        //Find a empty slot
        for (int i = 0; i < InventorySlots.Length; i++)
        {
            InventorySlot slot = InventorySlots[i];
            InventoryItem iteminslot = slot.GetComponentInChildren<InventoryItem>();
            if (iteminslot != null && iteminslot.item == item && iteminslot.count < Maxstackeditems && iteminslot.item.stackable == true)
            {
                iteminslot.count++;
                iteminslot.Refreshcount();
                return true;
            }
        }
        return false;
    }

    void SpawnNewItems(Item item, InventorySlot slot)
    {
        GameObject newItemGo = Instantiate(InventoryItemPrefab, slot.transform);
        InventoryItem inventoryItem = newItemGo.GetComponent<InventoryItem>();
        inventoryItem.InistialiseItem(item);
    }
}
