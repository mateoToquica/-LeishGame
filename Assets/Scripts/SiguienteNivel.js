#pragma strict

function OnTriggerEntre(Col :  Collider){


	if(Col.tag == "pj"){

		Application.LoadLevel("Menu");
	}
}