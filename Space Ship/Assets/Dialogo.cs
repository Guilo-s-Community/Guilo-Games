using UnityEngine;

[CreateAssetMenu(fileName = "DialogoBin", menuName = "ScriptableObjects/Dialogo", order = 1)]
public class Dialogo : ScriptableObject
{
    public string nomePersonagem;
    [TextArea(3, 10)]
    public string[] falas;
}
