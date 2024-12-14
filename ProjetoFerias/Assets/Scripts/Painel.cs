using UnityEngine;

public class Painel : MonoBehaviour
{
    public GameObject painel; // Referência ao painel a ser ativado/desativado

    // Método para ativar o painel
    public void AtivarPainel()
    {
        painel.SetActive(true);
    }

    // Método para desativar o painel
    public void DesativarPainel()
    {
        painel.SetActive(false);
    }
}