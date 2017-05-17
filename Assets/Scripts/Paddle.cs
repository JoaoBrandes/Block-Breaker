using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currPosition = this.transform.position;
		float mousePosInBlocks = (Input.mousePosition.x / Screen.width * 16);
		Vector3 paddlePos = new Vector3(Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f), currPosition.y, 0.0f);

		this.transform.position = paddlePos;

	}
}
