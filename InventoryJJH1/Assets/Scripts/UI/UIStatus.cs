using UnityEngine;
using TMPro;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI attackText, defenseText, hpText, speedText;
    [SerializeField] private GameObject backButton;

    public void SetData(Character character)
    {
        attackText.text = character.GetTotalAttack().ToString();
        defenseText.text = character.GetTotalDefense().ToString();
        hpText.text = character.CurrentHP.ToString();
        speedText.text = character.GetTotalSpeed().ToString();
    }

    private void Start()
    {
        backButton.GetComponent<Button>().onClick.AddListener(() => UIManager.Instance.ShowMainMenu());
    }
}