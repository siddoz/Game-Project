using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    public Item[] startItems;

    public int Maxstackeditems = 30;
    public InventorySlot[] InventorySlots;
    public GameObject InventoryItemPrefab;

    int selectedSlot = -1;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        ChangedselectedSlot(0);
        foreach (var item in startItems)
        {
            AddItem(item);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangedselectedSlot(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangedselectedSlot(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChangedselectedSlot(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ChangedselectedSlot(3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            ChangedselectedSlot(4);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            ChangedselectedSlot(5);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            ChangedselectedSlot(6);
        }
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

    public Item GetSelectedItem(bool use)
    {
        InventorySlot slot = InventorySlots[selectedSlot];
        InventoryItem iteminslot = slot.GetComponentInChildren<InventoryItem>();
        if (iteminslot != null)
        {
            Item item = iteminslot.item;
            if (use == true)
            {
                iteminslot.count--;
                if (iteminslot.count <= 0)
                {
                    Destroy(iteminslot.gameObject);
                }
                else
                {
                    iteminslot.Refreshcount();
                }
            }
            return item;
        }
        return null;
    }
}
