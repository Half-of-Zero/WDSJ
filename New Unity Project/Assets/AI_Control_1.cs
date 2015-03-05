using UnityEngine;
using System.Collections;

public class AI_Control_1 : MonoBehaviour 
{
	public float fieldOfViewAngle = 110f;	
	public GameObject player;
	public GameObject me;
	// Use this for initialization
	private NavMeshAgent nav;
	private Vector3 playerpos;
	private Vector3 home;
	private bool chase;
	private bool playerInSight;
	private SphereCollider col;
	
	void Start()
	{
		home = me.transform.position;
		playerpos = player.transform.position;
		nav = GetComponent<NavMeshAgent>();
		col = GetComponent<SphereCollider>();
	}
	// Update is called once per frame

	void FixedUpdate()
	{
		if (chase==true);
		{

			playerpos = player.transform.position;
		}
	}

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject == player)
		{
			chase=true;
			Vector3 direction = other.transform.position - transform.position;
			float angle = Vector3.Angle(direction, transform.forward);
			
			// If the angle between forward and where the player is, is less than half the angle of view...
			if(angle < fieldOfViewAngle * 0.5f)
			{
				RaycastHit hit;
				
				// ... and if a raycast towards the player hits something...
				if(Physics.Raycast(transform.position + transform.up, direction.normalized, out hit, col.radius))
				{
					// ... and if the raycast hits the player...
					if(hit.collider.gameObject == player)
					{
						// ... the player is in sight.
						playerInSight = true;
					}
				}
			}
			col.radius = 20f;
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject == player)
		{	
			chase=false;
			nav.destination=home;
			if (me.transform.position!=home)
			{
				SphereCollider myCollider = transform.GetComponent<SphereCollider>();
				myCollider.radius = 15f;
			}
		}
	}
}

