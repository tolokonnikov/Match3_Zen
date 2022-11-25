using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "Create GameConfig")]
public class Config : ScriptableObject
{
    public int width = 10;
    public int height = 20;
}
