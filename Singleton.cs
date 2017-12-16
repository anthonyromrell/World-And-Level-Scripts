using UnityEngine;

[System.Serializable]
public class Singleton
{
    private Singleton()
    {
    }

    private static Singleton _instance;

    public static Singleton Instance
    {
        get
        {
            GetData();
            return _instance;
        }
    }

    private static void GetData()
    {
        _instance = !string.IsNullOrEmpty(PlayerPrefs.GetString("GameData"))
            ? JsonUtility.FromJson<Singleton>(PlayerPrefs.GetString("GameData"))
            : new Singleton();
    }

    public void SaveDataFromInstance()
    {
        PlayerPrefs.SetString("GameData", JsonUtility.ToJson(this));
    }

    public static void SetData()
    {
        PlayerPrefs.SetString("GameData", JsonUtility.ToJson(_instance));
    }
}