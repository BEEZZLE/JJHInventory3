using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public Character player;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        SetData();
    }

    private void SetData()
    {
        player = new Character("Chad", 10, 100, 20, 15, 5);

        player.AddItem(new Item("검 +10", ItemType.Weapon, 10, 0, 0, 0));
        player.AddItem(new Item("방패", ItemType.Armor, 0, 10, 20, 0));
        player.AddItem(new Item("장신구", ItemType.Accessory, 0, 0, 10, 5));

        UIManager.Instance.MainMenu.SetCharacter(player);
        UIManager.Instance.StatusUI.SetCharacter(player);
        UIManager.Instance.InventoryUI.Init(player);
    }
}
