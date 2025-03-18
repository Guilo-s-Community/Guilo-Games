using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlayer : MonoBehaviour
{
    // Start is called before the first frame update
  void Start () {
    rb2d = GetComponent<Rigidbody2D>();     
}

    public KeyCode moveLeft = KeyCode.A;     
    public KeyCode moveRight = KeyCode.D;   
    public KeyCode moveUp = KeyCode.W;     
    public KeyCode moveDown = KeyCode.S;   
    
    public float speed = 10.0f;          
    public float boundX = 0.0f;         
    private Rigidbody2D rb2d;            

    void Update () {
    var vel = rb2d.linearVelocity;             
    if (Input.GetKey(moveLeft)) {           
        vel.x = -speed;
    }
    else if (Input.GetKey(moveRight)) {     
        vel.x = speed;                    
    }
    else if (Input.GetKey(moveUp)) {     
        vel.y = speed;                    
    }
    else if (Input.GetKey(moveDown)) {     
        vel.y = -speed;                    
    }
    else if (Input.GetKey(moveDown) & Input.GetKey(moveRight)) {     
        vel.y = -speed;      
        vel.x = speed;              
    }
    else {
        vel.x = 0;  
        vel.y = 0;                    
    }
    rb2d.linearVelocity = vel;                  

    var pos = transform.position;         
    transform.position = pos;              
   
}  
    private void OnTriggerEnter2D(Collider2D hitInfo)
        {
            if (hitInfo.tag == "Tower")
                {
                    ScoreScript.instance.AddScore(10); 

                }
        }

}