using UnityEngine;
using System.Collections;

public class BoxPushing : MonoBehaviour {
	GameObject player;
	// Use this for initialization
	void Awake () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject == player) {
			Rigidbody body = player.GetComponent<Rigidbody>();
			
			if (body == null || body.isKinematic)
				return;
			if (0f < -0.3f)
				return;
			Vector3 pushDir = new Vector3 (4f, 0f, 7f);
			body.velocity = pushDir * 2;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
