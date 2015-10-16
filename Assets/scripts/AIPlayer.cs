using UnityEngine;
using System.Collections;



public class AIPlayer : Player {

	public int zm = -9;
	public int xm = 6;
	public static string commandLine;
	public int direction = 0; 

	// Use this for initialization
	void Start () {

	}



	
	// Update is called once per frame
	void Update () {
		
	}



	
	public override void TurnUpdate ()	
	{
		 
		string[] commandLine = (string[]) GuiMatrix.block1.Clone();
		//commandLine = new string[5];
		if (Vector3.Distance(moveDestination, transform.position) > 0.1f) {
			transform.position += (moveDestination - transform.position).normalized * moveSpeed * Time.deltaTime;
			
			if (Vector3.Distance(moveDestination, transform.position) <= 0.1f) {
				transform.position = moveDestination;
				GameManager.instance.nextTurn();
			}
		} else {

			/*
			moveDestination = new Vector3(0 - Mathf.Floor(GameManager.instance.mapSize/2),1.5f, -0 + Mathf.Floor(GameManager.instance.mapSize/2));

			moveDestination = new Vector3(4 - Mathf.Floor(GameManager.instance.mapSize/2),1.5f, -0 + Mathf.Floor(GameManager.instance.mapSize/2));

			moveDestination = new Vector3(2 - Mathf.Floor(GameManager.instance.mapSize/2),1.5f, -11 + Mathf.Floor(GameManager.instance.mapSize/2));

			*/
			for (int i = 0; i < 5; i++){

				switch(commandLine[i]){
				case "UP":

					switch(direction){
					case 0:
						zm = zm + 1;
						break;
					case 3:
						xm = xm + 1;
						break;
					case 6:
						zm = zm - 1;
						break;
					case 9:
						xm = xm + 1;
						break;
					}
					moveDestination = new Vector3(xm - Mathf.Floor(GameManager.instance.mapSize/2),1.5f, zm + Mathf.Floor(GameManager.instance.mapSize/2));
					break;
				case "DOWN":
					zm = zm - 1;
					moveDestination = new Vector3(xm - Mathf.Floor(GameManager.instance.mapSize/2),1.5f, zm + Mathf.Floor(GameManager.instance.mapSize/2));
					break;
					
				case "LEFT":
					direction = direction + 3;
					if (direction == 0){
						direction = 0;
					}
					break;
					
				case "RIGHT":
					if (direction == 0){
						direction = 12;
					}
					direction = direction - 3;
					break;
				

				case "F1":
					i = 0;
					commandLine = (string[]) GuiMatrix.block2.Clone();
					break;
					
				case "F2":
					i=0;
					commandLine = (string[]) GuiMatrix.block3.Clone();
					break;
				
				case "ACTION":
					break;
				}
			
			}

			


		}
		
		base.TurnUpdate ();
	}
}
