using UnityEngine;

public class PlataformaFase2 : MonoBehaviour
{
    public float minZ = 63f; // Posição mínima no eixo Z
    public float maxZ = 70f; // Posição máxima no eixo Z
    public float speed = 2f; // Velocidade de movimento

    private bool movingUp = true; // Determina a direção do movimento

    void Update()
    {
        // Verifica a direção e move a plataforma
        if (movingUp)
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
            if (transform.position.z >= maxZ)
            {
                movingUp = false;
            }
        }
        else
        {
            transform.position -= Vector3.forward * speed * Time.deltaTime;
            if (transform.position.z <= minZ)
            {
                movingUp = true;
            }
        }
    }
}

