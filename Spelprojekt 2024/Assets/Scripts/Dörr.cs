using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dörr : MonoBehaviour
{
    public GameObject Hus;
    public GameObject varld;
    private bool appna = false;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Dörr öppna");
        appna = true;
        if (Input.GetKeyDown(KeyCode.F) && appna == true)
        {
            varld.SetActive(false);
            Hus.SetActive(true);
        }
    }
}
