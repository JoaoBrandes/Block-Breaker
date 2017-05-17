using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public Paddle paddle;
	static bool isLaunched;

	// Use this for initialization
	void Start () {
        isLaunched = false;
		Vector3 initPos = paddle.transform.position;
		this.transform.position = new Vector3( initPos.x, initPos.y, 0f );
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0) && !isLaunched) {
			Debug.Log("Mouse Clicked");
			isLaunched = true;
			Rigidbody2D rb = GetComponent<Rigidbody2D>();
			rb.AddForce(new Vector2(10f, 10f), ForceMode2D.Impulse);
		}

		if (isLaunched == false) {
			//Lock ball above the paddle
			Vector3 initPos = paddle.transform.position;
			this.transform.position = new Vector3( initPos.x, initPos.y + 0.5f, 0f );
		}
	}


}
