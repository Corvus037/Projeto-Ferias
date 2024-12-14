using UnityEngine;



using UnityEngine.SceneManagement; // Necessário para carregar cenas

public class Life : MonoBehaviour
{
    public float life = 100f; // Vida inicial do player
    public float lifeDecreaseRate = 1f; // Quantidade de vida perdida por segundo
    public string gameOverScene; // Nome da cena a ser carregada quando a vida chegar a 0

    void Update()
    {
        // Reduz a vida a cada segundo
        life -= lifeDecreaseRate * Time.deltaTime;

        // Garante que a vida não seja menor que zero
        if (life <= 0)
        {
            life = 0;
            OnPlayerDeath();
        }
    }

    private void OnPlayerDeath()
    {
        Debug.Log("Player morreu! Trocando para a cena: " + gameOverScene);

        // Troca para a cena configurada no Inspetor
        if (!string.IsNullOrEmpty(gameOverScene))
        {
            SceneManager.LoadScene(gameOverScene);
        }
        else
        {
            Debug.LogWarning("Nenhuma cena foi definida no campo 'Game Over Scene' do Inspetor!");
        }
    }
}
