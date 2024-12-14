using UnityEngine;

public class Platform : MonoBehaviour
{
    public float minY = 3f; // Posição mínima no eixo Y
    public float maxY = 7f; // Posição máxima no eixo Y
    public float speed = 2f; // Velocidade da plataforma

    private bool movingUp = true; // Indica se a plataforma está subindo

    void Update()
    {
        // Verifica a direção do movimento
        if (movingUp)
        {
            // Move para cima
            transform.position += Vector3.up * speed * Time.deltaTime;
            
            // Alcançou a posição máxima?
            if (transform.position.y >= maxY)
            {
                movingUp = false; // Inverte a direção
            }
        }
        else
        {
            // Move para baixo
            transform.position += Vector3.down * speed * Time.deltaTime;
            
            // Alcançou a posição mínima?
            if (transform.position.y <= minY)
            {
                movingUp = true; // Inverte a direção
            }
        }
    }
}

