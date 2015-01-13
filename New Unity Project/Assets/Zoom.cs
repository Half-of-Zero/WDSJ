using UnityEngine;
using System.Collections;

public class Zoom : MonoBehaviour 
{
	public Camera main;
	public int zoom;
	public GameObject reg;
	public GameObject zoomed;
	private bool fire=false;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		if (Input.GetMouseButtonDown (0))
		{
			fire=true;
		}
		if (Input.GetMouseButtonUp (0))
		{
			fire=false;
		}
		if (Input.GetMouseButtonDown (1)&&fire==false) 
		{
			reg.SetActive(false);
			zoomed.SetActive(true);
			main.fieldOfView = zoom;
		} 
		else if (Input.GetMouseButtonUp (1)&&fire==false) 
		{
			reg.SetActive(true);
			zoomed.SetActive(false);
			main.fieldOfView = 40;
		}
	}
}
