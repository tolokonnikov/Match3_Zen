using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class JewelView : MonoBehaviour
{
    private Jewel _jewel;

    public void Link(Jewel jewel)
    {
        _jewel = jewel;
    }
}

public class JewelViewFactory
{
    private GameObject _parent;

    [Inject]
    private readonly DiContainer _container;

    [Inject]
    private readonly Config _config;

    public JewelViewFactory()
    {
        _parent = GameObject.Find("GameBoardHolder");
    }

    public JewelView Create(string type)
    {
        GameObject prefab = _config.getJewelPrefab(type);
        JewelView view = _container.InstantiatePrefabForComponent<JewelView>(prefab, _parent.transform);
        return view;
    }
}
