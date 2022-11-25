using UnityEngine;
using Zenject;

public class Game
{
    [Inject]
    private Config _config;
    [Inject]
    private JewelFactory _jewelFactory;
    public void StartGame()
    {
        Debug.Log($"Game::StartGame  {_config.height} / {_config.width}");

        var test = _jewelFactory.Create("yellow");

        Debug.Log($"test: {test.GetGevelType()}");
    }
}
