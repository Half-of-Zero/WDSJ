

var Effect : Transform;
var MuzzleFlash : Light;
var TheDammage = 100;
var CrateDamage = 1;
var fireOn=1;
var fireRate=.1;
var ammoText : UI.Text;
var MagAmmo=69;
var ammo=69;
var MaxMags=6;
var Mags = 4;

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
	 else if (Input.GetKeyDown(KeyCode.R))//RELOADS
	 {
	 	if(Mags>0){
			ammo=MagAmmo;
			Mags--;
		}
		// add animation Declartion here
	}
	//ammoText.text=ammo.ToString()+"/"+Mags.ToString();
}

function setMags(toSet : float){
Mags = toSet;
}

function getAmmo(target : GameObject){
target.SendMessage("setAmmo",ammo, SendMessageOptions.DontRequireReceiver);
}

function setAmmo(otherAmmo : float){
ammo = otherAmmo;
}

function flash() 
{	
	MuzzleFlash.enabled = true;
	yield WaitForSeconds(.1);
	MuzzleFlash.enabled = false;
}

function ammoPickup(){
	if(Mags!=MaxMags)
	Mags++;
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
}