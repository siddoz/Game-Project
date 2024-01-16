using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject MainInventory;
    public static bool AvPa = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (AvPa == true)
            {
                MainInventory.SetActive(false);
                AvPa = false;
            }
            else
            {
                MainInventory.SetActive(true);
                AvPa = true;
            }
        }
    }
}
