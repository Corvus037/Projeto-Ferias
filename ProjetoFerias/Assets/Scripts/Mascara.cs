using UnityEngine;

public class Mascara : MonoBehaviour
{
    public float restoreAmount = 100f; // Quantidade de vida restaurada
    private bool playerInRange = false; // Verifica se o player está na área

    void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que entrou no trigger tem a tag "Player"
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Verifica se o objeto que saiu do trigger tem a tag "Player"
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    void Update()
    {
        // Verifica se o player está na área e a tecla "E" foi pressionada
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
           Life playerLife = FindObjectOfType<Life>();

            if (playerLife != null)
            {
                playerLife.life = restoreAmount; // Restaura a vida do player
                Debug.Log("Vida restaurada para: " + restoreAmount);
            }
        }
    }
}

