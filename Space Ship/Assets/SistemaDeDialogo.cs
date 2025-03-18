using UnityEngine;
using TMPro; // Importante para usar o TextMeshPro
using System.Collections.Generic;

public class SistemaDeDialogo : MonoBehaviour
{
    public TextMeshProUGUI nomeText;  // Usando TextMeshProUGUI
    public TextMeshProUGUI falaText;  // Usando TextMeshProUGUI
    public GameObject painelDeDialogo;

    private Queue<string> falas;

    void Start()
    {
        falas = new Queue<string>();
    }

    public void IniciarDialogo(Dialogo dialogo)
    {
        painelDeDialogo.SetActive(true);  // Ativa o painel de diálogo
        nomeText.text = dialogo.nomePersonagem;
        falas.Clear();

        foreach (string fala in dialogo.falas)
        {
            falas.Enqueue(fala);
        }

        ProximaFala();
    }

    public void ProximaFala()
    {
        if (falas.Count == 0)
        {
            FimDoDialogo();
            return;
        }

        string falaAtual = falas.Dequeue();
        falaText.text = falaAtual;
    }

    void FimDoDialogo()
    {
        painelDeDialogo.SetActive(false);  // Desativa o painel de diálogo
    }
}
