using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartScript : MonoBehaviour
{
    public Image heartsPrefab; // Array com os ícones de vida
    public Sprite fullHeart;  // Sprite do coração cheio
    public Sprite noHeart;  // Sprite do coração meio cheio

    private List<Image> hearts = new List<Image>();
    public int maxHearts = 3; // Vida máxima 

    
    public void SetMaxHearts(int maxHearts)
    {
        foreach(Image heart in hearts)
        {
            Destroy(heart.gameObject);
        }
        hearts.Clear();

        for (int i = 0; i < maxHearts; i++)
        {
            Image newHeart = Instantiate(heartsPrefab, transform);
            newHeart.sprite = fullHeart;
            hearts.Add(newHeart);
        }
    }

    public void UpdateHearts(int currentHealth)
    {
        for (int i = 0; i < hearts.Count; i++)
        {
            if (i < currentHealth)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = noHeart;
            }
        }
    }
}
