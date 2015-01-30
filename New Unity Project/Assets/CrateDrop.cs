using UnityEngine;
using System.Collections;

public class CrateDrop : MonoBehaviour {
	public int health = 5;


	void crateHit (int damage){
		health -= damage;
		//if (health == 0)
			//breakCrate ();
	}

	//void breakCrate(){
		//Random rnd = new Random ();
		//int drops = rnd.Range (0, 3);
		//for (int i=0; i<drops; i++) {
		//	int dropType = rnd.Range(1,4);
		//	Instantiate();
		//}
	//}
}
