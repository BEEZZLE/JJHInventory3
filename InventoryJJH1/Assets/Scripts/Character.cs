using System.Collections.Generic;
using System.Linq;

public class Character
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int BaseHP { get; private set; }
    public int BaseAttack { get; private set; }
    public int BaseDefense { get; private set; }
    public int BaseSpeed { get; private set; }

    public List<Item> Inventory { get; private set; } = new();
    public Dictionary<ItemType, Item> EquippedItems { get; private set; } = new();

    public Character(string name, int level, int hp, int atk, int def, int spd)
    {
        Name = name;
        Level = level;
        BaseHP = hp;
        BaseAttack = atk;
        BaseDefense = def;
        BaseSpeed = spd;
    }

    public Character(string v1, int v2, int v3, int v4, string v5)
    {
        V1 = v1;
        V2 = v2;
        V3 = v3;
        V4 = v4;
        V5 = v5;
    }

    public void AddItem(Item item) => Inventory.Add(item);

    public void Equip(Item item)
    {
        if (EquippedItems.ContainsKey(item.Type))
            EquippedItems[item.Type] = item;
        else
            EquippedItems.Add(item.Type, item);
    }

    public void UnEquip(Item item)
    {
        if (EquippedItems.ContainsKey(item.Type) && EquippedItems[item.Type] == item)
            EquippedItems.Remove(item.Type);
    }

    // 능력치 합산
    public int TotalAttack => BaseAttack + EquippedItems.Values.Sum(i => i.Attack);
    public int TotalDefense => BaseDefense + EquippedItems.Values.Sum(i => i.Defense);
    public int TotalHP => BaseHP + EquippedItems.Values.Sum(i => i.HP);
    public int TotalSpeed => BaseSpeed + EquippedItems.Values.Sum(i => i.Speed);

    public string V1 { get; }
    public int V2 { get; }
    public int V3 { get; }
    public int V4 { get; }
    public string V5 { get; }
    public float MaxHP { get; internal set; }
    public float CurrentHP { get; internal set; }
}
