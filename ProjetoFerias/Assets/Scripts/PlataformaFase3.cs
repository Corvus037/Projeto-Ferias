using UnityEngine;

public class PlataformaFase3 : MonoBehaviour
{
    public float pointAX; // Ponto A no eixo X
    public float pointBX; // Ponto B no eixo X
    public float speed = 2f; // Velocidade de movimento da plataforma

    private bool movingToPointB = true; // Controla a direção de movimento

    void Update()
    {
        if (movingToPointB)
        {
            // Move a plataforma em direção ao ponto B
            float targetPositionX = Mathf.Lerp(transform.position.x, pointBX, speed * Time.deltaTime);
            transform.position = new Vector3(targetPositionX, transform.position.y, transform.position.z);

            if (Mathf.Approximately(transform.position.x, pointBX))
            {
                movingToPointB = false; // Inverte a direção para voltar ao ponto A
            }
        }
        else
        {
            // Move a plataforma em direção ao ponto A
            float targetPositionX = Mathf.Lerp(transform.position.x, pointAX, speed * Time.deltaTime);
            transform.position = new Vector3(targetPositionX, transform.position.y, transform.position.z);

            if (Mathf.Approximately(transform.position.x, pointAX))
            {
                movingToPointB = true; // Inverte a direção para voltar ao ponto B
            }
        }
    }
}