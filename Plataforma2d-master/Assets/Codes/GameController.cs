using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using NUnit.Framework.Internal;
using System;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    int progressAmount;   
    public Slider progressSlider;
    public GameObject player;
    public GameObject LoadCanvas;
    public List<GameObject> levels;
    private int currentLevelIndex = 0;
    public GameObject gameOverScreen;
    public TMP_Text survivedText;
    private int survivedLevelsCount;
    public static event Action OnReset;
    void Start()
    {
        progressAmount = 0;
        progressSlider.value = 0;
        GemScript.OnGemCollect += IncreaseProgressAmount;
        holdNextLevel.OnHoldComplete += LoadNextLevel;
        PlayerHealth.OnPlayerDied += GameOverScreen;
        gameOverScreen.SetActive(false);
        LoadCanvas.SetActive(false);
    }

    void GameOverScreen()
    {
        gameOverScreen.SetActive(true);
        survivedText.text = "VOCÊ SOBREVIVEU " + survivedLevelsCount + " LEVEL";

        if (survivedLevelsCount != 1) survivedText.text += "S";
        Time.timeScale = 0;
    }

    void GanhouScreen()
    {
        
    }

    void IncreaseProgressAmount(int amount)
    {
        progressAmount += amount;
        progressSlider.value = progressAmount;
        if(progressAmount >= 100)
        {
            LoadCanvas.SetActive(true);
        }
    }

    public void ResetGame()
    {
        gameOverScreen.SetActive(false);
        survivedLevelsCount = 0;
        LoadLevel(0, false);
        OnReset.Invoke();
        Time.timeScale = 1;
        SceneManager.LoadScene("CenaJogo");
    }

    void LoadLevel(int level, bool wantSurvivedIncrease)
    {
        LoadCanvas.SetActive(false);

        levels[currentLevelIndex].gameObject.SetActive(false);
        levels[level].gameObject.SetActive(true);

        player.transform.position = new Vector3(0,0,0);
        currentLevelIndex = level;
        progressAmount = 0;
        progressSlider.value = 0;
        survivedLevelsCount ++;
        if (wantSurvivedIncrease) survivedLevelsCount++;
        
    }
    void LoadNextLevel()
    {
        int nextLevelIndex = (currentLevelIndex == levels.Count - 1) ? 0: currentLevelIndex + 1;
        LoadLevel(nextLevelIndex, true);
        
    }

    void Update()
    {
        if (currentLevelIndex == 1 && progressAmount >= 100)
        {
            SceneManager.LoadSceneAsync("Ganhou");
        }
    }
}
