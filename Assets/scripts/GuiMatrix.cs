

using UnityEngine;
using System.Collections;



public class GuiMatrix : MonoBehaviour {

	public Vector3 playerPosition = new Vector3(7,7,7);
	public Vector3 playerPosition2 = new Vector3(0,0,0);

	private string command11 = "UP";private string command12 = "UP";private string command13 = "UP";private string command14 = "UP";private string command15 = "UP";
	private string command21 = "UP";private string command22 = "UP";private string command23 = "UP";private string command24 = "UP";private string command25 = "UP";
	private string command31 = "UP";private string command32 = "UP";private string command33 = "UP";private string command34 = "UP";private string command35 = "UP";
	private string start = "Start";

	//public block1[] array = new block1(command11, command12, command13, command14, command15);
	//public string[] block2 = (command21, command22, command23, command24, command25);
//	public string[] block3 = {command31, command32, command33, command34, command35};

	//ArrayList block1 = new ArrayList(5);

	public static string[] block1;
	public static string[] block2;
	public static string[] block3;



	void OnGUI () {

		//
		block1 = new string[5];
		block1 [0] = command11; block1 [1] = command12; block1 [2] = command13; block1 [3] = command14; block1 [4] = command15;


		block2 = new string[5];
		block2 [0] = command21; block2 [1] = command22; block2 [2] = command23; block2 [3] = command24; block2 [4] = command25;


		block3 = new string[5];
		block3 [0] = command31; block3 [1] = command32; block3 [2] = command33; block3 [3] = command34; block3 [4] = command35;






		// Make a background box
		GUI.Box(new Rect(30,30,300,80), "Function Main");
		
		// Main Group
		if(GUI.Button(new Rect(50,50,50,50), command11)) {
			switch(command11){
			case "UP":
				command11 = "DOWN";
				break;
			case "DOWN":
				command11 = "LEFT";
				break;
			
			case "LEFT":
				command11 = "RIGHT";
				break;
			
			case "RIGHT":
				command11 = "ACTION";
				break;
			
			case "ACTION":
				command11 = "JUMP";
				break;
			
			case "JUMP":
				command11 = "F1";
				break;
						
			case "F1":
				command11 = "F2";
				break;
			
			case "F2":
				command11 = "UP";
				break;
			
			}	
		}

		if(GUI.Button(new Rect(100,50,50,50), command12)) {

			switch(command12){
			case "UP":
				command12 = "DOWN";
				break;
			case "DOWN":
				command12 = "LEFT";
				break;
				
			case "LEFT":
				command12 = "RIGHT";
				break;
				
			case "RIGHT":
				command12 = "ACTION";
				break;
				
			case "ACTION":
				command12 = "JUMP";
				break;
				
			case "JUMP":
				command12 = "F1";
				break;
				
			case "F1":
				command12 = "F2";
				break;
				
			case "F2":
				command12 = "UP";
				break;
				
			}	
		}
		if(GUI.Button(new Rect(150,50,50,50), command13)) {
			switch(command13){
			case "UP":
				command13 = "DOWN";
				break;
			case "DOWN":
				command13 = "LEFT";
				break;
				
			case "LEFT":
				command13 = "RIGHT";
				break;
				
			case "RIGHT":
				command13 = "ACTION";
				break;
				
			case "ACTION":
				command13 = "JUMP";
				break;
				
			case "JUMP":
				command13 = "F1";
				break;
				
			case "F1":
				command13 = "F2";
				break;
				
			case "F2":
				command13 = "UP";
				break;
				
			}	
		}
		if(GUI.Button(new Rect(200,50,50,50), command14)) {
			switch(command14){
			case "UP":
				command14 = "DOWN";
				break;
			case "DOWN":
				command14 = "LEFT";
				break;
				
			case "LEFT":
				command14 = "RIGHT";
				break;
				
			case "RIGHT":
				command14 = "ACTION";
				break;
				
			case "ACTION":
				command14 = "JUMP";
				break;
				
			case "JUMP":
				command14 = "F1";
				break;
				
			case "F1":
				command14 = "F2";
				break;
				
			case "F2":
				command14 = "UP";
				break;
				
			}	
		}
		if(GUI.Button(new Rect(250,50,50,50), command15)) {
			switch(command15){
			case "UP":
				command15 = "DOWN";
				break;
			case "DOWN":
				command15 = "LEFT";
				break;
				
			case "LEFT":
				command15 = "RIGHT";
				break;
				
			case "RIGHT":
				command15 = "ACTION";
				break;
				
			case "ACTION":
				command15 = "JUMP";
				break;
				
			case "JUMP":
				command15 = "F1";
				break;
				
			case "F1":
				command15 = "F2";
				break;
				
			case "F2":
				command15 = "UP";
				break;
				
			}	
		}
		// End Main Group



// Function Group

//Start F1
		GUI.Box(new Rect(30,110,300,80), "Function One");

		if(GUI.Button(new Rect(50,130,50,50), command21)) {
			switch(command21){
			case "UP":
				command21 = "DOWN";
				break;
			case "DOWN":
				command21 = "LEFT";
				break;
				
			case "LEFT":
				command21 = "RIGHT";
				break;
				
			case "RIGHT":
				command21 = "ACTION";
				break;
				
			case "ACTION":
				command21 = "JUMP";
				break;
				
			case "JUMP":
				command21 = "F2";
				break;
				
			case "F2":
				command21 = "UP";
				break;
				
			}	
		}
		if(GUI.Button(new Rect(100,130,50,50), command22)) {
			switch(command22){
			case "UP":
				command22 = "DOWN";
				break;
			case "DOWN":
				command22 = "LEFT";
				break;
				
			case "LEFT":
				command22 = "RIGHT";
				break;
				
			case "RIGHT":
				command22 = "ACTION";
				break;
				
			case "ACTION":
				command22 = "JUMP";
				break;
				
			case "JUMP":
				command22 = "F2";
				break;
				
			case "F2":
				command22 = "UP";
				break;
				
			}	
		}
		if(GUI.Button(new Rect(150,130,50,50), command23)) {
			switch(command23){
			case "UP":
				command23 = "DOWN";
				break;
			case "DOWN":
				command23 = "LEFT";
				break;
				
			case "LEFT":
				command23 = "RIGHT";
				break;
				
			case "RIGHT":
				command22 = "ACTION";
				break;
				
			case "ACTION":
				command23 = "JUMP";
				break;
				
			case "JUMP":
				command23 = "F2";
				break;
				
			case "F2":
				command23 = "UP";
				break;
				
			}	
		}
		if(GUI.Button(new Rect(200,130,50,50), command24)) {
			switch(command24){
			case "UP":
				command24 = "DOWN";
				break;
			case "DOWN":
				command24 = "LEFT";
				break;
				
			case "LEFT":
				command24 = "RIGHT";
				break;
				
			case "RIGHT":
				command24 = "ACTION";
				break;
				
			case "ACTION":
				command24 = "JUMP";
				break;
			
			case "JUMP":
				command24 = "F2";
				break;
				
			case "F2":
				command24 = "UP";
				break;
				
			}	
		}
		if(GUI.Button(new Rect(250,130,50,50), command25)) {
			switch(command25){
			case "UP":
				command25 = "DOWN";
				break;
			case "DOWN":
				command25 = "LEFT";
				break;
				
			case "LEFT":
				command25 = "RIGHT";
				break;
				
			case "RIGHT":
				command25 = "ACTION";
				break;
				
			case "ACTION":
				command25 = "JUMP";
				break;
				
			case "JUMP":
				command25 = "F2";
				break;

			case "F2":
				command25 = "UP";
				break;
				
			}	
		}
// End F1

// Start F2
		GUI.Box(new Rect(30,190,300,80), "Function Two");
		
		if(GUI.Button(new Rect(50,210,50,50), command31)) {
			switch(command31){
			case "UP":
				command31 = "DOWN";
				break;
			case "DOWN":
				command31 = "LEFT";
				break;
				
			case "LEFT":
				command31 = "RIGHT";
				break;
				
			case "RIGHT":
				command31 = "ACTION";
				break;
				
			case "ACTION":
				command31 = "JUMP";
				break;
				
			case "JUMP":
				command31 = "F1";
				break;
				
			case "F1":
				command31 = "UP";
				break;
				
			}	
		}
		if(GUI.Button(new Rect(100,210,50,50), command32)) {
			switch(command32){
			case "UP":
				command32 = "DOWN";
				break;
			case "DOWN":
				command32 = "LEFT";
				break;
				
			case "LEFT":
				command32 = "RIGHT";
				break;
				
			case "RIGHT":
				command32 = "ACTION";
				break;
				
			case "ACTION":
				command32 = "JUMP";
				break;
				
			case "JUMP":
				command32 = "F1";
				break;
				
			case "F1":
				command32 = "UP";
				break;
				
			}	
		}
		if(GUI.Button(new Rect(150,210,50,50), command33)) {
			switch(command33){
			case "UP":
				command33 = "DOWN";
				break;
			case "DOWN":
				command33 = "LEFT";
				break;
				
			case "LEFT":
				command33 = "RIGHT";
				break;
				
			case "RIGHT":
				command33 = "ACTION";
				break;
				
			case "ACTION":
				command33 = "JUMP";
				break;
				
			case "JUMP":
				command33 = "F1";
				break;
				
			case "F1":
				command33 = "UP";
				break;
				
			}	
		}
		if(GUI.Button(new Rect(200,210,50,50), command34)) {
			switch(command34){
			case "UP":
				command34 = "DOWN";
				break;
			case "DOWN":
				command34 = "LEFT";
				break;
				
			case "LEFT":
				command34 = "RIGHT";
				break;
				
			case "RIGHT":
				command34 = "ACTION";
				break;
				
			case "ACTION":
				command34 = "JUMP";
				break;
				
			case "JUMP":
				command34 = "F1";
				break;
				
			case "F1":
				command34 = "UP";
				break;
				
			}	
		}
		if(GUI.Button(new Rect(250,210,50,50), command35)) {
			switch(command35){
			case "UP":
				command35 = "DOWN";
				break;
			case "DOWN":
				command35 = "LEFT";
				break;
				
			case "LEFT":
				command35 = "RIGHT";
				break;
				
			case "RIGHT":
				command35 = "ACTION";
				break;
				
			case "ACTION":
				command35 = "JUMP";
				break;
				
			case "JUMP":
				command35 = "F1";
				break;

			case "F1":
				command35 = "UP";
				break;
				
			}	
		}
// End F2

// Call Move
		if (GUI.Button (new Rect (30, 280, 120, 40), start)) {
			switch(start){
			case "Start":
				GameManager.instance.moveCommandPlayer (playerPosition);

				start = "Stop";
				break;
			
			case "Stop":
				start = "Start";
				//if (Application.loadedLevelName == "ARTest1"){
				//Application.LoadLevel ("ARTest2");
				/*
				switch (Application.loadedLevelName){
				case "ARTest1":
					Application.LoadLevel ("ARTest2");
					break;
				case "ARTest2":
					Application.LoadLevel ("ARTest3");
					break;
				case "ARTest3":
					Application.LoadLevel ("ARTest1");
					break;

				}
*/

				
				//}
				break;

			}

			//initiateMove();
			//GameManager.instance.moveCurrentPlayer (this);
				//Debug.Log (this);
				/*
		if (gridPosition.x == 0 && gridPosition.y == 0) {
						Debug.Log ("ha um obstaculo aqui");
				} else {
						GameManager.instance.moveCurrentPlayer (this);
				}
		*/




		}
	
	}
}