using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
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

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();

    }

    void Update()
    {
        if (score >= 1109){
        SceneManager.LoadScene("Ganhou");
    }
    }

    

    
}
