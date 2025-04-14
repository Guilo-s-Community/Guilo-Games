using UnityEngine;
using System; 
public class GemScript : MonoBehaviour, Iitem
{
    public static event Action<int> OnGemCollect;
    public int worth = 5;
    public void Collect()
    {
        OnGemCollect.Invoke(worth);
        Destroy(gameObject);
    }

}
