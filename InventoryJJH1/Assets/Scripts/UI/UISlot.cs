using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UISlot : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI itemNameText;
    [SerializeField] private Button equipButton;

    private Item item;
    private Character owner;

    public void SetItem(Item newItem, Character character)
    {
        item = newItem;
        owner = character;
        RefreshUI();

        equipButton.onClick.RemoveAllListeners();
        equipButton.onClick.AddListener(() => ToggleEquip());
    }

    private void ToggleEquip()
    {
        if (owner.EquippedWeapon == item || owner.EquippedArmor == item)
            owner.UnEquip(item);
        else
            owner.Equip(item);

        UIManager.Instance.StatusUI.SetData(owner);
        UIManager.Instance.InventoryUI.SetData(owner);
    }

    private void RefreshUI()
    {
        itemNameText.text = item.Name;
    }
}