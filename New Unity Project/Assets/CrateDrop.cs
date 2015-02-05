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


	}
}
