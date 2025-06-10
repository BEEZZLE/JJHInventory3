public enum ItemType { Weapon, Armor }

public class Item
{
    public string Name;
    public ItemType Type;
    public int Value;

    public Item(string name, ItemType type, int value)
    {
        Name = name;
        Type = type;
        Value = value;
    }
}