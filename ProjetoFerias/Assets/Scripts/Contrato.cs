using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Contrato : MonoBehaviour
{
       public TextMeshProUGUI textDisplay; // O componente TextMeshPro na UI
       public  string contractText; // O texto do contrato
      public  float typingSpeed = 0.05f; // Velocidade de digitação (segundos entre cada caractere)
      public  GameObject buttonToActivate; // Botão ou objeto a ser ativado ao final

     int currentCharIndex = 0;

    void Start()
    {
        // Garante que o texto comece vazio
        if (textDisplay != null)
        {
            textDisplay.text = "";
            StartCoroutine(TypeText());
        }
        else
        {
            Debug.LogWarning("TextMeshProUGUI não foi atribuído no inspetor!");
        }

        // Garante que o botão esteja desativado no início
        if (buttonToActivate != null)
        {
            buttonToActivate.SetActive(false);
        }
        else
        {
            Debug.LogWarning("Nenhum botão foi atribuído no campo Button To Activate!");
        }
    }

    private System.Collections.IEnumerator TypeText()
    {
        // Digita o texto caractere por caractere
        while (currentCharIndex < contractText.Length)
        {
            textDisplay.text += contractText[currentCharIndex];
            currentCharIndex++;
            yield return new WaitForSeconds(typingSpeed);
        }

        // Chama a função após terminar de digitar
        OnTypingComplete();
    }

    private void OnTypingComplete()
    {
        Debug.Log("Contrato concluído!");

        // Ativa o botão
        if (buttonToActivate != null)
        {
            buttonToActivate.SetActive(true);
        }
    }
}