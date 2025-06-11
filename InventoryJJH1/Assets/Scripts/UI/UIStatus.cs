using TMPro;
using UnityEngine;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI attackText;
    [SerializeField] private TextMeshProUGUI defenseText;
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI speedText;

    public void SetCharacter(Character character)
    {
        attackText.text = $"���ݷ�: {character.TotalAttack}";
        defenseText.text = $"����: {character.TotalDefense}";
        hpText.text = $"ü��: {character.TotalHP}";
        speedText.text = $"�ӵ�: {character.TotalSpeed}";
    }
}
