using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class EnemyHealthManager : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;
    public Transform respawnPoint;
    public float respawnDelay = 2f;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void HurtEnemy(int damageToGive)
    {
        currentHealth -= damageToGive;
        if (currentHealth <= 0)
        {
            Debug.Log("setnotactive");
            gameObject.SetActive(false);
            Invoke("RespawnAfterDelay", 2f);
            //StartCoroutine(RespawnAfterDelay());
        }
    }

    private void RespawnAfterDelay()
    {
        transform.position = respawnPoint.position;
        currentHealth = maxHealth;
        Debug.Log("setacttive");
        gameObject.SetActive(true);
    }
}



