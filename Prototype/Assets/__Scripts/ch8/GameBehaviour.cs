using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBehaviour : MonoBehaviour, IManager
{
    private int _itemCollected = 0;
    private int _playerHP = 10;
    private int _maxItems = 4;
    private string _labelText = "Collect all 4 items and win your freedom!";
    private string _state;

    public bool _showWinScreen = false;
    public bool _showLossScreen = false;

    public Stack<string> LootStack = new Stack<string>();

    public int Items
    {
        get => _itemCollected;
        set
        {
            _itemCollected = value;
            if (_itemCollected >= _maxItems)
            {
                PutOnScreen("You've found all the items!", "_showWinScreen", 0);
            }
            else
            {
                _labelText = $"Item found, only {_maxItems - _itemCollected} more to go!";
            }
        }
    }
    public int PlayerHP
    {
        get => _playerHP;
        set
        {
            _playerHP = value;

            if (_playerHP <= 0)
            {
                PutOnScreen("You want another life with that?", "_showLossScreen", 0);
            }
            else
            {
                _labelText = "Ouch... that's got hurt";
            }
            Debug.Log($"Player HP: {_playerHP}");
        }
    }

    public string State { get => _state; set => _state = value; }

    public delegate void DebugDelegate(string newText);
    public DebugDelegate debug = Print;

    private void Start()
    {
        Initialize();

        InventoryList<string> inventoryList = new InventoryList<string>();
        inventoryList.GenericMethod(34);
        inventoryList.SetItem("Potion");
        Debug.Log(inventoryList.Item);
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 150, 25), $"Player Health: {_playerHP}");
        GUI.Box(new Rect(20, 50, 150, 25), $"Items collected: {_itemCollected}");

        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 300, 50), _labelText);

        if (_showWinScreen)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "YOU WIN!"))
            {
                try
                {
                    Utilities.RestartLevel(-1);
                    debug("Level reastarted successfully...");
                }
                catch (System.ArgumentException e)
                {
                    Utilities.RestartLevel(0);
                    debug($"Reverting to scene 0: {e.ToString()}");
                }
                finally
                {
                    debug("Restart handled");
                }
            }
        }

        if (_showLossScreen)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "You LOSS..."))
            {
                Utilities.RestartLevel();
            }
        }
    }

    private void PutOnScreen(string labelText, string screen, float timeScale)
    {
        _labelText = labelText;

        switch (screen)
        {
            case "_showWinScreen":
                _showWinScreen = true;
                break;
            case "_showLossScreen":
                _showWinScreen = true;
                break;
        }

        Time.timeScale = timeScale;
    }

    public void Initialize()
    {
        _state = "Manager initialized...";
        Debug.Log(_state);

        LootStack.Push("Sword of Doom");
        LootStack.Push("HP+");
        LootStack.Push("Golden Key");
        LootStack.Push("Winget Boot");
        LootStack.Push("Mythril Bracers");

        debug(_state);
        LogWithDelegate(debug);

        GameObject player = GameObject.Find("Player");
        PlayerBehaviour playerBehaviour = player.GetComponent<PlayerBehaviour>();
        playerBehaviour.PlayerJump += HandlePlayerJump;
    }

    private void HandlePlayerJump()
    {
        Debug.Log("Player has jumped...");
    }

    public void PrintLootReport()
    {
        var currentItem = LootStack.Pop();
        var nextItem = LootStack.Peek();

        Debug.Log($"You got {currentItem}! You've got a good chance of finding a {nextItem} next!");

        Debug.Log($"There are {LootStack.Count} random loot items waiting for you!");
    }

    public static void Print(string newText)
    {
        Debug.Log(newText);
    }

    public void LogWithDelegate(DebugDelegate del)
    {
        del("Delegeting the debug task");
    }
}
