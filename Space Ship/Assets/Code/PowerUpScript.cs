using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class PowerUpScript : MonoBehaviour
{
    public float slowMotionDuration = 1f; 
    public float slowMotionFactor = 0.5f;

    public float speed;
    
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.right * -speed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(ApplySlowMotion());
        }
        if (other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator ApplySlowMotion()
    {
        // Aplica o efeito de slow motion
        Time.timeScale = slowMotionFactor;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowMotionFactor;

        // Desativa o objeto do power-up
        gameObject.SetActive(false);

        // Aguarda a duração do efeito
        yield return new WaitForSecondsRealtime(slowMotionDuration);

        // Restaura o timeScale e fixedDeltaTime originais
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowMotionFactor;

        // Destroi o objeto do power-up
        Destroy(gameObject);
    }
    
}
