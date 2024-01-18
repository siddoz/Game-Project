using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class EnemyHealthManager : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    public void HurtEnemy(int damageToGive)
    {
        currentHealth -= damageToGive;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}



