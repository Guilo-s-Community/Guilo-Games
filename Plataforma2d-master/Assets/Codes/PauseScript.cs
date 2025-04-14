using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class PauseScript : MonoBehaviour
{
    public static bool IsGamePaused {get; private set;} = false;
    public static void SetPause(bool pause)
    {
        IsGamePaused = pause;
    }
    
}
