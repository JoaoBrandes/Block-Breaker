using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
    private static int totalBricks;
    public int timesHit;
  
    public Sprite[] damageLevel;
	// Use this for initialization
	void Start () {
        timesHit = 0;
        totalBricks++;
	}

    public static void resetBrickCount()
    {
        Debug.Log("Reseting brick Count.");
        totalBricks = 0;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag.Equals("Ball") && this.tag.Equals("Breakable"))
        {
            timesHit++;
            int brickHealth = damageLevel.Length + 1;
            if (timesHit >= brickHealth)
            {
                Destroy(gameObject);
                totalBricks--;
                Debug.Log("Destruindo um brick. Restantes: "+totalBricks);
                if (totalBricks == 0)
                {
                    LevelManager.getInstance().LoadNextLevel();
                }
            } else
            {
                LoadSprite();
            }
        }
    }

    void LoadSprite()
    {
        int damage = timesHit - 1;
        if (damageLevel[damage]) {
            this.GetComponent<SpriteRenderer>().sprite = damageLevel[damage];
        }
    }
}
