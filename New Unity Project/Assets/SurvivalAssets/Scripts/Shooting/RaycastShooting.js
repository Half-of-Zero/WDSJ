 #pragma strict

var Effect : Transform;
var MuzzleFlash : Light;
var TheDammage = 100;
var CrateDamage = 1;
var fireOn=1;
var fireRate=.1;
var ammoText : GUIText;
var MaxAmmo=42;
var ammo=42;

function Start()
{
	MuzzleFlash.enabled=false;
}

function Update ()
{
	if (Input.GetMouseButton(0))
	{
		if (fireOn==1)
		{
			fireOn=0;
			fire();	
		}
	}
	 else if (Input.GetKeyDown(KeyCode.R))
	 {
		ammo=MaxAmmo;
		// add animation Declartion here
	}
	ammoText.text=ammo.ToString()+"/"+MaxAmmo.ToString();
}
function flash() 
{	
	MuzzleFlash.enabled = true;
	yield WaitForSeconds(.1);
	MuzzleFlash.enabled = false;
}
function fire()
{
	var hit : RaycastHit;
	var ray : Ray = Camera.main.ScreenPointToRay(Vector3(Screen.width*0.5, Screen.height*0.5, 0));
	if (ammo>0)
	{
		flash();
		if (Physics.Raycast (ray, hit, 100))
		{
			var particleClone = Instantiate(Effect, hit.point, Quaternion.LookRotation(hit.normal));
			Destroy(particleClone.gameObject, 2);
			if (hit.rigidbody.gameObject.tag == "Enemy")
				hit.transform.SendMessage("ApplyDammage", TheDammage, SendMessageOptions.DontRequireReceiver);
			else if (hit.rigidbody.gameObject.tag == "Breakable")
				hit.transform.SendMessage("crateHit", CrateDamage, SendMessageOptions.DontRequireReceiver);
		}
		ammo--;
	}		
	yield WaitForSeconds(fireRate);
	fireOn=1;
	audio.Play(0);
}