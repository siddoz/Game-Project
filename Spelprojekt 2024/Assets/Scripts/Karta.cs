using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karta : MonoBehaviour
{
    public GameObject Map;
    public static bool AvPa = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (AvPa == true)
            {
                Map.SetActive(false);
                AvPa = false;
            }
            else
            {
                Map.SetActive(true);
                AvPa = true;
            }
        }
    }
}
