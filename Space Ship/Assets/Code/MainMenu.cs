using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    void Start(){
        instructionsPanel.SetActive(false);
    }
    public GameObject instructionsPanel;
    public void PlayGame(){
        SceneManager.LoadSceneAsync("CenaJogo");
    }
    public void QuitGame(){
        Application.Quit();
    }
    
    public void OpenInstructions()
    {
        instructionsPanel.SetActive(true);
    }

    public void Menu(){
        SceneManager.LoadSceneAsync("MainMenu");
    }

}
