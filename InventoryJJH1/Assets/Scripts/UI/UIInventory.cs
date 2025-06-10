using UnityEngine;
using System.Collections.Generic;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform slotParent;

    private List<UISlot> slots = new();

    public void SetData(Character character)
    {
        foreach (Transform child in slotParent) Destroy(child.gameObject);
        slots.Clear();

        foreach (Item item in character.Inventory)
        {
            GameObject slotGO = Instantiate(slotPrefab, slotParent);
            UISlot slot = slotGO.GetComponent<UISlot>();
            slot.SetItem(item, character);
            slots.Add(slot);
        }
    }
}