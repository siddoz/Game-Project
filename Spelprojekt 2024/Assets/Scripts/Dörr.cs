using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dörr : MonoBehaviour
{
    public GameObject Hus;
    public GameObject varld;
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.F) && collision.gameObject.name == "Player")
        {
            Debug.Log("Dörr öppna");
            varld.SetActive(false);
            Hus.SetActive(true);
        }
    }
}
