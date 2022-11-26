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

        var types = new string[] { "red", "blue", "green", "purple", "yellow" };

        for (int i = 0; i < _config.height; i++)
            for (int j = 0; j < _config.width; j++)
            {
                var jewelView = Create(types[Random.Range(0, 5)]);
                jewelView.transform.position = new Vector3(i, j, 0) - new Vector3(_config.height / 2, _config.width / 2, 0);
            }

    }

    private JewelView Create(string type)
    {
        var jewel = _jewelFactory.Create(type);
        JewelView jewelView = _jewelViewFactory.Create(type);
        jewelView.Link(jewel);
        return jewelView;
    }
}
