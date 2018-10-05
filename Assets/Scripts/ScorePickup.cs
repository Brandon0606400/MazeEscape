using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour {

    public Score scoreTracker;
    public int scoreValue = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Only do stuff if it's the player we've hit
        if (collision.GetComponent<Player>())
        {
            // updating the score based on how much this item is worth
            scoreTracker.ChangeValue(scoreValue);
            
            // remove the item when it is used
            Destroy(gameObject);
        }
    }



}
