using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
	

	public Vector2 obstaclePosition = Vector2.zero;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseEnter() {
		transform.renderer.material.color = Color.yellow;
		
		//Debug.Log ("pos (" + obstaclePosition.x + "," + obstaclePosition.y + ")");
		
	}
	
	void OnMouseExit() {
		transform.renderer.material.color = Color.gray;
	}
	
	
	//void OnMouseDown() {
	//	GameManager.instance.moveCurrentPlayer(this);
	//}
	
	
}
