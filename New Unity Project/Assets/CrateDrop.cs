using UnityEngine;
using System.Collections;

public class CrateDrop : MonoBehaviour {
	public int health = 5;
	public GameObject powerup1;
	public GameObject powerup2;
	public GameObject powerup3;

	void crateHit (int damage){
		health -= damage;
		if (health == 0)
			breakCrate ();
	}

	void breakCrate(){
		int drops =Random.Range (0, 3);
		for (int i=0; i<drops; i++) {
			int dropType =0+ Random.Range(1,4);
			Instantiate(powerup1);
		}
	}
}
