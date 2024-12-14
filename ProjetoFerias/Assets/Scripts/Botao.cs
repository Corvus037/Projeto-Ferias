using UnityEngine;
using UnityEngine.SceneManagement; // Necessário para trocar de cena

public class Botao : MonoBehaviour
{
    public string sceneToLoad; // Nome da cena a ser carregada

    public void TrocarCena()
    {
        SceneManager.LoadScene(sceneToLoad); // Troca diretamente para a cena configurada
    }
}