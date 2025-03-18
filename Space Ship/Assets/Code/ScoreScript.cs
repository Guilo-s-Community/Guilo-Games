using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public static ScoreScript instance; // Singleton para fácil acesso ao score
    public TextMeshProUGUI scoreText; // Referência ao componente de texto
    private int score = 0;

    private void Awake()
    {
        // Garantir que apenas uma instância do ScoreManager exista
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        UpdateScoreText();
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }
    public void SubScore(int points)
    {
        score -= points;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
