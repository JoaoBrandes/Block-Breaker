using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null; 

	void Awake ()
	{
		//if (instance != null) {
		//	Debug.Log("Destruindo no Awake");
		//	GameObject.Destroy(gameObject);
		//}
	}

	// Use this for initialization
	void Start ()
	{
		if (instance == null) {
			Debug.Log ("Criando nova música");

			GameObject.DontDestroyOnLoad (gameObject);
			instance = this;
		} else {
			Debug.Log("Destruindo nova música");
			GameObject.Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
