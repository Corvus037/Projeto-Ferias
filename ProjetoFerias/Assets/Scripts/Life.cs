using UnityEngine;


public class Life : MonoBehaviour
{
    public float life = 100f; // Vida inicial do player
    public float lifeDecreaseRate = 1f; // Quantidade de vida perdida por segundo

    void Update()
    {
        // Reduz a vida a cada segundo
        life -= lifeDecreaseRate * Time.deltaTime;

        // Garante que a vida não seja menor que zero
        if (life <= 0)
        {
            life = 0;
            // Chama função de morte ou reinício (pode ser implementada depois)
            OnPlayerDeath();
        }
    }

    private void OnPlayerDeath()
    {
        Debug.Log("Player morreu!");
        // Implementar lógica de morte, como reiniciar a cena ou exibir uma mensagem de game over
    }
}
