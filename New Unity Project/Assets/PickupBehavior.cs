using UnityEngine;
using System.Collections;

public class PickupBehavior : MonoBehaviour {
	public GameObject player;
	public enum puType{ammo, health, money};
	public puType thisType;
	void pickupActivate(){
		if (thisType == puType.ammo) {


		}
	}
}
