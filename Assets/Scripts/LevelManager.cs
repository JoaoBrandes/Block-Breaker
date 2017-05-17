using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	static LevelManager _instance = null;

	public static LevelManager getInstance() {
		return _instance;
	}

	void Start ()
	{
		if (_instance == null) {
			_instance = this;
		}
	}
	
	public void LoadLevel (string name)
	{
		Debug.Log("Level load requested for "+name);
		SceneManager.LoadSceneAsync (name);

	}

	public static void QuitRequest () {
		Debug.Log("Quitting");
		Application.Quit();
	}
}
