using UnityEngine;
using TMPro;

public class PlayerLifeUI : MonoBehaviour
{
    public Life playerLife; // Referência ao script de vida do jogador
    public TextMeshProUGUI lifeText; // Referência ao componente TextMeshProUGUI

    void Update()
    {
        // Atualiza o texto na UI com a vida atual do jogador
        if (playerLife != null && lifeText != null)
        {
            lifeText.text = "Oxygen: " + Mathf.CeilToInt(playerLife.life).ToString();
        }
    }
}
