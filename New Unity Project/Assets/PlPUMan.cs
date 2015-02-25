using UnityEngine;
using System.Collections;

public class PlPUMan : MonoBehaviour {

	public GameObject gun1;
	public GameObject gun2;

	void ammoPickup(){
		//print ("7 managers managing");
		gun1.SendMessage ("ammoPickup", SendMessageOptions.DontRequireReceiver);
		gun2.SendMessage ("ammoPickup", SendMessageOptions.DontRequireReceiver);
	}
}
