using UnityEngine;

public class Mouse : MonoBehaviour
{
    void Start()
    {
        // Desbloqueia o cursor e o torna visível
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
