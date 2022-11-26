using UnityEngine;
using Zenject;

public class Game
{
    [Inject]
    private Config _config;
    [Inject]
    private JewelFactory _jewelFactory;
    [Inject]
    private JewelViewFactory _jewelViewFactory;
    public void StartGame()
    {
        Debug.Log($"Game::StartGame  {_config.height} / {_config.width}");

        var test = _jewelFactory.Create("red");
        JewelView jewelView = _jewelViewFactory.Create("red");
        jewelView.Link(test);

        Debug.Log($"test: {test.GetGevelType()}");
    }
}
