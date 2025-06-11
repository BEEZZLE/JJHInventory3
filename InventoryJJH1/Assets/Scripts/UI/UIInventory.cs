using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Transform slotParent;
    [SerializeField] private GameObject slotPrefab;

    private List<UISlot> slots = new();

    public void Init(Character character)
    {
        foreach (Transform child in slotParent)
            Destroy(child.gameObject);

        slots.Clear();

        foreach (Item item in character.Inventory)
        {
            GameObject go = Instantiate(slotPrefab, slotParent);
            UISlot slot = go.GetComponent<UISlot>();
            slot.Init(item, character);
            slots.Add(slot);
        }
    }

    public void Refresh()
    {
        foreach (UISlot slot in slots)
            slot.RefreshUI();
    }
}
