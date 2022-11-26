using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Match3Core
{
    [Inject]
    private Config _config;

    private JewelCell[,] _cells;
    private IMatch3CoreListener _match3CoreListener;

    public int W { get => _config.width; }
    public int H { get => _config.height; }

    public void Init(IMatch3CoreListener listener)
    {
        _match3CoreListener = listener;
        _cells = new JewelCell[W, H];

        for (int i=0; i<W; i++)
            for(int j=0; j<H; j++)
            {
                _cells[i, j] = new JewelCell(i, j);
                _cells[i, j].jewel = _match3CoreListener.OnNeedJewel();
            }
    }
}

public struct JewelCoordinate
{
    public int x; public int y;
    public JewelCoordinate(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public class JewelCell
{
    public JewelCoordinate coordinate;
    public Jewel jewel;
    public JewelCell(int x, int y)
    {
        coordinate = new JewelCoordinate(x, y);
    }
}

public interface IMatch3CoreListener
{
    Jewel OnNeedJewel();
}
