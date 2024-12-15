using UnityEngine;
using UnityEngine.SceneManagement;

public class Cheat : MonoBehaviour
{
    public  string sceneToLoad; // Nome da cena a ser carregada

    void Update()
    {
        // Verifica se o jogador pressionou a tecla Z
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // Troca para a cena especificada
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}