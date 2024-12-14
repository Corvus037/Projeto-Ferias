using UnityEngine;



public class ToxicPlataform : MonoBehaviour
{
    public float damagePerSecond = 1f; // Dano por segundo
    public bool playerInContact = false; // Verifica se o player está em contato
    public Life Life; // Referência ao script de vida do player

    void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que entrou em contato tem a tag "Player"
        if (other.CompareTag("Player"))
        {
            playerInContact = true;
            Life = other.GetComponent<Life>(); // Obtém o script de vida do player
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Verifica se o objeto que saiu do contato tem a tag "Player"
        if (other.CompareTag("Player"))
        {
            playerInContact = false;
            Life = null; // Remove a referência ao script de vida
        }
    }

    void Update()
    {
        // Aplica dano enquanto o player estiver em contato
        if (playerInContact && Life != null)
        {
            Life.life -= damagePerSecond * Time.deltaTime;

            // Garante que a vida não seja menor que zero
            if (Life.life < 0)
            {
                Life.life = 0;
            }
        }
    }
}
