using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using System.Collections;

public class VideoController : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.Play();
        videoPlayer.loopPointReached += OnVideoEnd; // Evento chamado ao final do vídeo
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        StartCoroutine(LoadSceneWithLoadingScreen("LoadingScene", "Cena1")); // Substitua "NomeDaCena" pela cena alvo
    }

    IEnumerator LoadSceneWithLoadingScreen(string loadingScene, string Cena1)
    {
        // Carrega a cena de loading
        SceneManager.LoadScene(loadingScene);

        // Aguarda um frame para garantir que a cena de loading foi carregada
        yield return null;

        // Inicia o carregamento assíncrono da cena alvo
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Cena1");
        asyncLoad.allowSceneActivation = false;

        // Tempo simulado de loading (opcional)
        yield return new WaitForSeconds(2f); 

        // Ativa a cena quando o carregamento estiver pronto
        asyncLoad.allowSceneActivation = true;
    }
}
