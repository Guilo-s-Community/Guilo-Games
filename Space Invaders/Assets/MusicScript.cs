using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public static MusicScript bgmusic;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
