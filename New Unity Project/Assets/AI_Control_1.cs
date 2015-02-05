using UnityEngine;
using System.Collections;

public class AI_Control_1 : MonoBehaviour 
{
	public GameObject player;
	// Use this for initialization
	private NavMeshAgent nav;
	
	void Start()
	{
		nav = GetComponent<NavMeshAgent>();
		Vector3 playercords = player.transform.position;
		nav.destination = playercords;
	}
	// Update is called once per frame
	void Update () 
	{
		Start ();
		print (nav.remainingDistance);
		if (nav.remainingDistance > 16f)
		{
			nav.Stop();
		}
	}
}

