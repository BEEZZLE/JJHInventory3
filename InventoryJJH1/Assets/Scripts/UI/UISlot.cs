using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI itemNameText;
    [SerializeField] private Button equipButton;

    private Item itemData;
    private Character character;

    public void Init(Item item, Character player)
    {
        itemData = item;
        character = player;
        RefreshUI();

        equipButton.onClick.RemoveAllListeners();
        equipButton.onClick.AddListener(() =>
        {
            if (character.EquippedItems.ContainsValue(itemData))
                character.UnEquip(itemData);
            else
                character.Equip(itemData);

            UIManager.Instance.InventoryUI.Refresh();
            UIManager.Instance.StatusUI.SetCharacter(character);
        });
    }

    public void RefreshUI()
    {
        string state = character.EquippedItems.ContainsValue(itemData) ? "(ÀåÂøÁß)" : "";
        itemNameText.text = $"{itemData.Name} {state}";
    }
}
