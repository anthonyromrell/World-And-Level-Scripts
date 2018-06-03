using System.Collections.Generic;
using RoboRyanTron.Unite2017.Variables;
using UnityEngine;

[CreateAssetMenu(fileName = "World")]
public class WorldBase : ScriptableObject
{
    public float GenerateRate = 0.1f;
    public List<GamePieceBase> Objects;
    public FloatVariable Speed;
}