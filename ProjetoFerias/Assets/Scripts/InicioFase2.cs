using UnityEngine;

public class InicioFase2 : MonoBehaviour
{
    public Porta doorController;  // Referência ao script da porta
    public Esfera sphereFollower; // Referência ao script das esferas

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Ativa a porta para começar a descer
            doorController.ActivateDoor();

            // Configura a variável de detecção das esferas para 10
            sphereFollower.detectionRadius = 10f;

            Debug.Log("Porta ativada e esferas começam a seguir!");
        }
    }
}