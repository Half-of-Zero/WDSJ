using UnityEngine;
using System.Collections;

public class Grounding : MonoBehaviour {
	Rigidbody thisRigidBody;
	int levelMask;
	Collider thisCollider;

	void Awake(){
		levelMask = LayerMask.GetMask ("Level");
		thisRigidBody = GetComponent<Rigidbody>();
		thisCollider = GetComponent<Collider>();
	}

	void OnCollisionStay(Collision col){
		GameObject other = col.gameObject;
		if (other.layer == levelMask) {
			Vector3 move = new Vector3();
			move.Set(0f, 1.0f, 0f);
			thisRigidBody.MovePosition(transform.position + move);
		}
	}

}