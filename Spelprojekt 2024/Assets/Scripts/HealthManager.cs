using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;
    public void HurtPlayer(int damageToGive)
    {
        Debug.Log("currencthealth:" +currentHealth);
        currentHealth -= damageToGive;
        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
        Debug.Log("currencthealth after damage:" + currentHealth);
    }
}

