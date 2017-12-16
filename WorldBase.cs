using UnityEngine;

public class WorldBase : ScriptableObject
{
    public Level[] Levels;
    public int CurrentWorld;
    public int CurrentLevel;

    public void GoToNextLevelHandler()
    {
        if (CurrentLevel < Levels[CurrentWorld].Waves.Length - 1)
        {
            CurrentLevel++;
            World.RunNextWave();
        }
        else
        {
            CurrentLevel = 0;
        }
    }
}

