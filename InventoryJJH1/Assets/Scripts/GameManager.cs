using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public Character Player { get; private set; }

    [SerializeField] private UIManager uiManager;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        SetData();
    }

    private void SetData()
    {
        Player = new Character("Chad", 10, 9, 12, "교단노예");

        Player.AddItem(new Item("Sword", ItemType.Weapon, 10));
        Player.AddItem(new Item("Shield", ItemType.Armor, 5));
        Player.AddItem(new Item("Helmet", ItemType.Armor, 3));

        uiManager.MainMenu.SetData(Player);
        uiManager.StatusUI.SetData(Player);
        uiManager.InventoryUI.SetData(Player);
    }
}