using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

    public int timesHit;
    public int maxHit;
	// Use this for initialization
	void Start () {
        timesHit = 0;
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag.Equals("Ball"))
        {
            timesHit++;
            if (timesHit >= maxHit)
            {
                Destroy(gameObject);
            }
        }
    }
}
