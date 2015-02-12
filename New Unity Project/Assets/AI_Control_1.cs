using UnityEngine;
using System.Collections;

public class AI_Control_1 : MonoBehaviour 
{
	public GameObject player;
	public GameObject me;
	// Use this for initialization
	private NavMeshAgent nav;
	private Vector3 playerpos;
	private Vector3 home;
	
	void Start()
	{
		home = me.transform.position;
		playerpos = player.transform.position;
		nav = GetComponent<NavMeshAgent>();
	}
	// Update is called once per frame

	void FixedUpdate()
	{
		playerpos = player.transform.position;
	}

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject == player)
		{
			nav.destination= playerpos;
			SphereCollider myCollider = transform.GetComponent<SphereCollider>();
			myCollider.radius = 20f;
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject == player)
		{
			nav.destination=home;
			if (me.transform.position!=home)
			{
				SphereCollider myCollider = transform.GetComponent<SphereCollider>();
				myCollider.radius = 15f;
			}
		}
	}
}

