using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText, levelText;
    [SerializeField] private Slider hpBar;
    [SerializeField] private Button statusButton, inventoryButton;

    public void SetData(Character character)
    {
        nameText.text = character.Name;
        levelText.text = "LV " + character.Level;
        hpBar.maxValue = character.MaxHP;
        hpBar.value = character.CurrentHP;
    }

    private void Start()
    {
        statusButton.onClick.AddListener(() => UIManager.Instance.ShowStatus());
        inventoryButton.onClick.AddListener(() => UIManager.Instance.ShowInventory());
    }
}
