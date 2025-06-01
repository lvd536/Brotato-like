using TMPro;
using UnityEngine;

public class UpdateStats : MonoBehaviour
{
    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI damageText;
    [SerializeField] private TextMeshProUGUI moveSpeed;
    [SerializeField] private TextMeshProUGUI attackSpeed;
    [Header("Data")]
    [SerializeField] private Player_ScriptableObject playerData;
    private void Awake()
    {
        healthText.text = playerData.health.ToString();
        damageText.text = playerData.damage.ToString();
        moveSpeed.text = playerData.moveSpeed.ToString();
        attackSpeed.text = playerData.attackSpeed.ToString();
    }
}
