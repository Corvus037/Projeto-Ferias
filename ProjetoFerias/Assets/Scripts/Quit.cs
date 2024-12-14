using UnityEngine;

public class Quit : MonoBehaviour
{
    public void Sair()
    {
        Debug.Log("Saindo do jogo..."); // Apenas para verificar no editor
        Application.Quit(); // Fecha o jogo ao ser compilado
    }
}

