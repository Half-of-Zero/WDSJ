using UnityEngine;
using System.Collections;

public class Zoom : MonoBehaviour 
{
	public Camera main;
	public int zoom;
	public GameObject reg;
	public GameObject zoomed;
	private bool fire=false;
	public int mags = 0;
	public int ammo =0;
	// Use this for initialization
	void Start () 
	{
	
	}
	void setAmmo(int toAmmo){
		ammo = toAmmo;
	}
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0))
		{
			fire=true;
		}
		if (Input.GetMouseButtonUp (0))
		{
			fire=false;
		}
		if (Input.GetMouseButtonDown (1)) 
		{
			reg.SetActive(false);
			zoomed.SetActive(true);
			reg.SendMessage("getAmmo", this.gameObject, SendMessageOptions.DontRequireReceiver);
			zoomed.SendMessage("setMags", mags, SendMessageOptions.DontRequireReceiver);
			zoomed.SendMessage("setAmmo", ammo, SendMessageOptions.DontRequireReceiver);
			main.fieldOfView = zoom;
		} 
		else if (Input.GetMouseButtonUp (1)) 
		{
			reg.SetActive(true);
			zoomed.SetActive(false);
			main.fieldOfView = 40;
		}
	}
}
