using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public abstract class Jewel 
{
    protected string _type = "unknown";

    public string GetGevelType() => _type; 
}

public class RedJevel : Jewel
{
    public const string RED = "red";

    private RedJevel() 
    {
        _type= RED;
    }

    public class Factory : PlaceholderFactory<RedJevel> { }
}

public class BlueJevel : Jewel
{
    public const string BLUE = "blue";

    private BlueJevel()
    {
        _type = BLUE;
    }

    public class Factory : PlaceholderFactory<BlueJevel> { }
}

public class PurpleJevel : Jewel
{
    public const string PURPLE = "purple";

    private PurpleJevel()
    {
        _type = PURPLE;
    }

    public class Factory : PlaceholderFactory<PurpleJevel> { }
}

public class GreenJevel : Jewel
{
    public const string GREEN = "green";

    private GreenJevel()
    {
        _type = GREEN;
    }

    public class Factory : PlaceholderFactory<GreenJevel> { }
}

public class YellowJevel : Jewel
{
    public const string YELLOW = "yellow";

    private YellowJevel()
    {
        _type = YELLOW;
    }

    public class Factory : PlaceholderFactory<YellowJevel> { }
}

public class JewelFactory
{
    [Inject]
    RedJevel.Factory _redJewelFactory;
    [Inject]
    BlueJevel.Factory _blueJewelFactory;
    [Inject]
    PurpleJevel.Factory _purpleJewelFactory;
    [Inject]
    GreenJevel.Factory _greenJewelFactory;
    [Inject]
    YellowJevel.Factory _yellowJewelFactory;

    public Jewel Create(string type)
    {
        switch(type)
        {
            case RedJevel.RED: 
                return _redJewelFactory.Create();
            case BlueJevel.BLUE:
                return _blueJewelFactory.Create();
            case PurpleJevel.PURPLE:
                return _purpleJewelFactory.Create();
            case GreenJevel.GREEN:
                return _greenJewelFactory.Create();
            case YellowJevel.YELLOW:
                return _yellowJewelFactory.Create();
        }

        Debug.LogError($"Unknown type of jewel: {type}");
        return null;
    }
}
