#pragma strict

var Weapon01 : GameObject;
var Weapon02 : GameObject;
var Weapon : int=1;
function Update () {
	if (Input.GetKeyDown(KeyCode.Q))
	{
		SwapWeapons();
	}
}

function SwapWeapons()
{
	if (Weapon==1)
	{
		Weapon=2;
		Weapon01.SetActive(false);
		Weapon02.SetActive(true);
	}
	else 
	{
		Weapon=1;
		Weapon01.SetActive(true);
		Weapon02.SetActive(false);
	}
}