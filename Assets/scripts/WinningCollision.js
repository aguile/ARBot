function OnCollisionEnter(theCollision : Collision){

	if (theCollision.gameObject == "Player"){
	Debug.Log("WINNER");
	}
}