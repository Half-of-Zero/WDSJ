using UnityEngine;
using System.Collections;

public class Zoom : MonoBehaviour 
{
	public Camera main;
	public int zoom;
	public GameObject reg;
	public GameObject zoomed;
	private bool fire=false;
	public float mags = 0;
	public float ammo =7;
	// Use this for initialization
	void Start () 
	{
	
	}
	void setAmmo(int toAmmo){
		ammo = toAmmo;
		print (toAmmo);
		print (ammo);
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
			reg.SendMessage("getAmmo", this.gameObject, SendMessageOptions.DontRequireReceiver);
			reg.SetActive(false);
			zoomed.SetActive(true);
			zoomed.SendMessage("setMags", mags, SendMessageOptions.DontRequireReceiver);
			zoomed.SendMessage("setAmmo", ammo, SendMessageOptions.DontRequireReceiver);
			main.fieldOfView = zoom;
		} 
		else if (Input.GetMouseButtonUp (1)) 
		{
			zoomed.SendMessage("getAmmo", this.gameObject, SendMessageOptions.DontRequireReceiver);
			reg.SetActive(true);
			reg.SendMessage("setMags", mags, SendMessageOptions.DontRequireReceiver);
			reg.SendMessage("setAmmo", ammo, SendMessageOptions.DontRequireReceiver);
			zoomed.SetActive(false);
			main.fieldOfView = 40;
		}
	}
}
