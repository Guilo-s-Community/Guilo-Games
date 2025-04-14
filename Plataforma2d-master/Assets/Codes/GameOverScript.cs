using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public RectTransform arrow; // Referência para a seta
    public TextMeshProUGUI[] options; // Lista das opções de texto
    private int currentIndex = 0; // Índice da opção atual

    void Start()
    {
        UpdateArrowPosition();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SelectOption();
        }
    }

    public void RetryGame(){
        SceneManager.LoadSceneAsync("CenaJogo");
    }

    void UpdateArrowPosition()
    {
        // Ajusta a posição da seta para a esquerda da opção selecionada
        arrow.position = new Vector3(270, options[currentIndex].transform.position.y, 0);
    }

    void SelectOption()
    {
        switch (options[currentIndex].text)
        {
            case "RETRY":
                RetryGame();
                break;
        }
    }
}
