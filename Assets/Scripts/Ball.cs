using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	static bool isLaunched;

    public int constantVelocity = 10;

	// Use this for initialization
	void Start () {
        isLaunched = false;
        paddle = GameObject.FindObjectOfType<Paddle>();
		Vector3 initPos = paddle.transform.position;
		this.transform.position = new Vector3( initPos.x, initPos.y, 0f );
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0) && !isLaunched) {
			Debug.Log("Ball Launched");
			isLaunched = true;
			Rigidbody2D rb = GetComponent<Rigidbody2D>();
			rb.AddForce(new Vector2(1f, 10f), ForceMode2D.Impulse);
		}

		if (isLaunched == false) {
			//Lock ball above the paddle
			Vector3 initPos = paddle.transform.position;
			this.transform.position = new Vector3( initPos.x, initPos.y + 0.5f, 0f );
		} else
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            Vector2 newVelocity = constantVelocity * (rb.velocity.normalized);
            newVelocity.x = rb.velocity.x;
            rb.velocity = newVelocity;
        }
	}


}
