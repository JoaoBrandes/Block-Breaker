using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other)
	{
 
		if (other.tag.Equals ("Ball")) {
			LevelManager.getInstance().LoadLevel ("Lose");
		}

	}
}
