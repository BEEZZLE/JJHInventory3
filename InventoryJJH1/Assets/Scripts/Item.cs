public enum ItemType { Weapon, Armor, Accessory }

public class Item
{
    public string Name { get; private set; }
    public ItemType Type { get; private set; }
    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int HP { get; private set; }
    public int Speed { get; private set; }

    public Item(string name, ItemType type, int atk, int def, int hp, int spd)
    {
        Name = name;
        Type = type;
        Attack = atk;
        Defense = def;
        HP = hp;
        Speed = spd;
    }

    public Item(string v1, ItemType armor, int v2)
    {
    }
}
