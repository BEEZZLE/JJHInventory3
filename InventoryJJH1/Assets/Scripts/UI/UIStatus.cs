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
        attackText.text = $"공격력: {character.TotalAttack}";
        defenseText.text = $"방어력: {character.TotalDefense}";
        hpText.text = $"체력: {character.TotalHP}";
        speedText.text = $"속도: {character.TotalSpeed}";
    }
}
