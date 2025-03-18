using UnityEngine;

public class ParallaxMenuScript : MonoBehaviour
{
    private float height;
    public float parallaxEffect;

    // Start is called before the first frame update
    void Start()
    {
        height = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        // Move o fundo para cima
        transform.position += Vector3.up * Time.deltaTime * parallaxEffect;

        // Reseta a posição quando o fundo sair da tela
        if (transform.position.y > height)
        {
            transform.position = new Vector3(transform.position.x, -height, transform.position.z);
        }
    }
}
