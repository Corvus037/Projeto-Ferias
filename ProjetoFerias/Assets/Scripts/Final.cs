using UnityEngine;

public class Final : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que entrou no Trigger tem a tag "Player"
        if (other.CompareTag("Player"))
        {
            // Fecha o jogo
            Debug.Log("Player entrou no Trigger! Fechando o jogo...");
            Application.Quit();
        }
    }
}