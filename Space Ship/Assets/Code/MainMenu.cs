using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    void Start(){
        instructionsPanel.SetActive(false);
    }
    public GameObject instructionsPanel;
    public void PlayGame(){
        SceneManager.LoadSceneAsync(1);
    }
    public void QuitGame(){
        Application.Quit();
    }
    
    public void OpenInstructions()
    {
        instructionsPanel.SetActive(true);
    }

}
