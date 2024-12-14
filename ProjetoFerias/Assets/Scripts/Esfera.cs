using UnityEngine;

public class Esfera : MonoBehaviour
{
    public Transform player; // Referência ao transform do jogador
    public float followSpeed = 2f; // Velocidade de movimento para seguir o jogador
    public float damageAmount = 10f; // Quantidade de dano que a esfera causará
    public float detectionRadius = 5f; // Distância em que as esferas começarão a seguir o jogador

    private Life playerLifeScript; // Referência ao script de vida do jogador

    void Start()
    {
        // Obtém a referência ao script de vida do jogador
        playerLifeScript = player.GetComponent<Life>();
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= detectionRadius)
        {
            // Move a esfera em direção ao jogador
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * followSpeed * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Verifica se colidiu com o jogador
        if (collision.gameObject.CompareTag("Player"))
        {
            // Causa dano ao jogador
            playerLifeScript.life -= damageAmount;
            Debug.Log("Dano causado pela esfera! Vida restante: " + playerLifeScript.life);
        }
    }
}