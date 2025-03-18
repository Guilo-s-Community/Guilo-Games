using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed;
    
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.right * -speed;
        transform.Rotate(0,0,0);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag == "Bullet" || hitInfo.tag == "Wall" || hitInfo.tag == "Player")
            {
                Destroy(gameObject);
            }
    }

}
