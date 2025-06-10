using System.Collections.Generic;

public class Character
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int CurrentHP { get; private set; }
    public int MaxHP { get; private set; }
    public string Job { get; private set; }

    public int BaseAttack = 20;
    public int BaseDefense = 5;
    public int BaseSpeed = 25;

    public List<Item> Inventory { get; private set; } = new();
    public Item EquippedWeapon;
    public Item EquippedArmor;

    public Character(string name, int level, int hp, int maxHP, string job)
    {
        Name = name;
        Level = level;
        CurrentHP = hp;
        MaxHP = maxHP;
        Job = job;
    }

    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public void Equip(Item item)
    {
        if (item.Type == ItemType.Weapon) EquippedWeapon = item;
        else if (item.Type == ItemType.Armor) EquippedArmor = item;
    }

    public void UnEquip(Item item)
    {
        if (EquippedWeapon == item) EquippedWeapon = null;
        else if (EquippedArmor == item) EquippedArmor = null;
    }

    public int GetTotalAttack() => BaseAttack + (EquippedWeapon?.Value ?? 0);
    public int GetTotalDefense() => BaseDefense + (EquippedArmor?.Value ?? 0);
    public int GetTotalSpeed() => BaseSpeed;
}
