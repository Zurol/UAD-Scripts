using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;       // Maximum player health
    public int currentHealth;       // Current player health

    private void Start()
    {
        currentHealth = maxHealth;  // Initialize health
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        // Play damage sound or animation here

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void HealDamage(int healAmount) {
        currentHealth += healAmount;

        if (currentHealth > maxHealth) {
            currentHealth = maxHealth;
        }

    }

    private void Die()
    {
        // Play death sound or animation here
        // Implement any game over logic (e.g., restart level)
    }
}
