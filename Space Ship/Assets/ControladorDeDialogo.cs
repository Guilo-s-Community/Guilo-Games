using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


public class ControladorDeDialogo : MonoBehaviour
{
    public SistemaDeDialogo sistemaDeDialogo;
    public Dialogo DialogoBin;

    void Start()
    {
        sistemaDeDialogo.IniciarDialogo(DialogoBin);
    }
}
