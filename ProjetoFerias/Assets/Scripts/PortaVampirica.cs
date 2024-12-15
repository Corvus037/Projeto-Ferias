using UnityEngine;

public class PortaVampirica : MonoBehaviour
{
    public float targetY = 2f; // Posição final da porta no eixo Y
    public float moveSpeed = 5f; // Velocidade do movimento da porta
    public float lifeCost = 10f; // Vida a ser reduzida do jogador

    private bool isMoving = false; // Controle do movimento da porta
    private bool isPlayerNearby = false; // Verifica se o jogador está próximo
    private Transform player; // Referência ao jogador

    void Update()
    {
        // Inicia o movimento se a porta estiver sendo movida
        if (isMoving)
        {
            Vector3 newPosition = transform.position;
            newPosition.y = Mathf.MoveTowards(transform.position.y, targetY, moveSpeed * Time.deltaTime);
            transform.position = newPosition;

            // Para o movimento ao atingir a posição final
            if (Mathf.Approximately(transform.position.y, targetY))
            {
                isMoving = false;
            }
        }

        // Detecta interação com o jogador
        if (isPlayerNearby && Input.GetKeyDown(KeyCode.E))
        {
            Life playerLife = player.GetComponent<Life>();
            if (playerLife != null)
            {
                // Reduz a vida do jogador
                playerLife.life -= lifeCost;
                if (playerLife.life < 0)
                {
                    playerLife.life = 0;
                }

                // Inicia o movimento da porta
                isMoving = true;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Verifica se o jogador encostou na porta
        if (collision.collider.CompareTag("Player"))
        {
            isPlayerNearby = true;
            player = collision.transform;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // Verifica se o jogador saiu de perto da porta
        if (collision.collider.CompareTag("Player"))
        {
            isPlayerNearby = false;
            player = null;
        }
    }
}