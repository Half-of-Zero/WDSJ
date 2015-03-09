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
		Vector3 d1Loc = new Vector3 (Random.Range (-.5F, .5F), 0F, Random.Range (-.5F, .5F));
		Instantiate (powerup1,this.gameObject.transform.position-d1Loc, this.transform.rotation);
		Destroy (this.gameObject);
	}
}
