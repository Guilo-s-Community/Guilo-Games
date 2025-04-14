using UnityEngine;
using UnityEngine.SceneManagement;

public class InstruictionsPanelController : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadSceneAsync("CenaJogo");
    }
    public void ClosePanel()
    {
        gameObject.SetActive(false);
    }
}
