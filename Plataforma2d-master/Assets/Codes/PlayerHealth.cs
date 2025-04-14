using System;
using System.Collections;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;
    public HeartScript heartScript;
    private SpriteRenderer spriteRenderer;
    public static event Action OnPlayerDied;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ResetHealth();
        spriteRenderer = GetComponent<SpriteRenderer>();
        GameController.OnReset +=ResetHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyScript enemy = collision.GetComponent<EnemyScript>();
        if(enemy)
        {
            TakeDamage(enemy.damage);
        }
    }
    void ResetHealth()
    {
        currentHealth = maxHealth;
        heartScript.SetMaxHearts(maxHealth);
    }

    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
        heartScript.UpdateHearts(currentHealth);
        StartCoroutine(flashRed());

        if(currentHealth <=0)
        {
            OnPlayerDied.Invoke();
        }
    }

    // Update is called once per frame
    private IEnumerator flashRed()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        spriteRenderer.color = Color.white;
    }
}
