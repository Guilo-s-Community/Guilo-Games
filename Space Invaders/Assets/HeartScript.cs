using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class HeartScript : MonoBehaviour
{
    public GameObject[] hearts;
    public int life;

    void Update(){
        if (life < 1){
            Destroy(hearts[0].gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene("Perdeu");
        } else if( life < 2){
            Destroy(hearts[1].gameObject);
        } else if( life < 3){
            Destroy(hearts[2].gameObject);
        }
    }

    private void OnTriggerEnter2D (Collider2D hitInfo) {
            if (hitInfo.tag == "BulletEnemy")
                {
                    life--;
                }
    }
}
