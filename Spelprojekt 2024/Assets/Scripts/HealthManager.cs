using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;
    private Vector2 startPosition;

    private void Start()
    {
        currentHealth = maxHealth;
        startPosition = transform.position;
    }
    public void HurtPlayer(int damageToGive)
    {
        Debug.Log("currencthealth:" + currentHealth);
        currentHealth -= damageToGive;
        if (currentHealth <= 0)
        {
            StartCoroutine(RespawnAfterDelay());
        }
        Debug.Log("currencthealth after damage:" + currentHealth);
    }

    private System.Collections.IEnumerator RespawnAfterDelay()
    {
        Debug.Log("Respawning");
        gameObject.SetActive(false);
        Debug.Log("1");
        
        Debug.Log("2");
        currentHealth = maxHealth;
        Debug.Log("Respawn position" + startPosition);

        transform.position = startPosition;

        gameObject.SetActive(true);
        Debug.Log("Player respawned");
        yield return new WaitForSeconds(1f);
    }
}

