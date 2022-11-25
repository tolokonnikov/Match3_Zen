using UnityEngine;
using Zenject;

public class GameController : MonoBehaviour
{
    [Inject]
    private Game _game;
    // Start is called before the first frame update
    void Start()
    {
        _game.StartGame();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
