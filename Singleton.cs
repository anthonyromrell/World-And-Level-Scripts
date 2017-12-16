using UnityEngine;

[System.Serializable]
public class Singleton {


	private static Singleton _instance;

	public static Singleton Instance {
		get
		{
			GetData();
			return _instance;
		}
	}

	private static void GetData () {
		if (string.IsNullOrEmpty(PlayerPrefs.GetString("GameData")))
		{
			_instance = new Singleton();
		} else
		{
			_instance = JsonUtility.FromJson<Singleton>(PlayerPrefs.GetString("GameData"));
		}
	}

	public void SaveDataFromInstance () {
		PlayerPrefs.SetString("GameData", JsonUtility.ToJson(this));
	}

	public static void SetData () {
		PlayerPrefs.SetString("GameData", JsonUtility.ToJson(_instance));
	}
}
