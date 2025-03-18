using UnityEngine;

public class BulletEnemyScript : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.up * -speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag != "Bullet" & hitInfo.tag != "BulletEnemy" & hitInfo.tag != "enemy")
            {
                Destroy(gameObject);
            }
    }
   

}
