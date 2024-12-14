using UnityEngine;
using UnityEngine.SceneManagement; 

public class TriggerMudarFase : MonoBehaviour
{
    [Tooltip("Nome da cena para onde deseja trocar")]
    public string sceneToLoad; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trocando para a cena: " + sceneToLoad);
            SceneManager.LoadScene(sceneToLoad); 
        }
    }
}