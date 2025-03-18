using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class enemyBullet : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;
    private int numero;

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag != "Bullet" & hitInfo.tag != "BulletEnemy" & hitInfo.tag != "enemy")
            {
                Destroy(gameObject);
            }
    }
   



}