using UnityEngine;
using UnityEngine.SceneManagement;

public class Esc : MonoBehaviour
{
     public  string sceneToLoad; // Nome da cena a ser carregada

    void Update()
    {
        // Verifica se o jogador pressionou a tecla Esc
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Troca para a cena especificada
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
