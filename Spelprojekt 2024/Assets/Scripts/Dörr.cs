using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dörr : MonoBehaviour
{
    public GameObject Hus;
    public GameObject varld;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Dörr öppna");
        if (Input.GetKeyDown(KeyCode.F) && collision.gameObject.name == "Player")
        {
            varld.SetActive(false);
            Hus.SetActive(true);
        }
    }
}
