using UnityEngine;

public class Porta : MonoBehaviour
{
    public float targetY = -35f; 
    public float speed = 5f; // Velocidade da descida da porta
    private bool isActivated = false;

    void Update()
    {
        if (isActivated)
        {
            // Move a porta gradualmente para o alvo Y
            float newY = Mathf.Lerp(transform.position.y, targetY, Time.deltaTime * speed);
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);

            // Desativar script quando chegar no alvo
            if (Mathf.Abs(transform.position.y - targetY) < 0.1f)
            {
                isActivated = false; // Caso a porta já tenha atingido o Y -35
            }
        }
    }

    // Função para ativar a descida da porta
    public void ActivateDoor()
    {
        isActivated = true;
    }
}
