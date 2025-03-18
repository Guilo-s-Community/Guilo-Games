using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float timer = 0.2f;
    private float waitTime = 25.0f;
    private float x;
    private float speed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();  
        x = transform.position.x;
        

        var vel = rb2d.linearVelocity;
        vel.x = speed;
        rb2d.linearVelocity = vel;
    }

    // Update is called once per frame
    void Update()
    {        
        timer += Time.deltaTime;
        if (timer >= waitTime){
            ChangeState();
            timer = 0.0f;
            Destroy(gameObject);
        }
    }
    void ChangeState(){
        var vel = rb2d.linearVelocity;
        vel.x *= 1f;
        rb2d.linearVelocity = vel;
    }
}
