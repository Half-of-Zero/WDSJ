using UnityEngine;
using System.Collections;

public class PickupBehavior : MonoBehaviour {
	public enum puType{ammo, health, money};
	public puType thisType;
	void pickupActivate(GameObject player){
		if (thisType == puType.ammo) {
			player.SendMessage("ammoPickup", SendMessageOptions.DontRequireReceiver);
			GameObject thisObject = this.gameObject;
			Destroy(thisObject);
		}
	}
}
