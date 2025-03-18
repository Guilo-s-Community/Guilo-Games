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
    else {
        vel.x = 0;                     
    }
    rb2d.linearVelocity = vel;                  

    var pos = transform.position;         
    transform.position = pos;              
   
}    

}



