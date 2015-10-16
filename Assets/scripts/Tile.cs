using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {
	
	public Vector3 gridPosition = Vector3.zero;
	public Vector2 obstaclePosition = Vector2.zero;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter() {
		//transform.renderer.material.color = Color.blue;
		/*
		 if (gridPosition.x == 0 && gridPosition.y == 0) {
						//Debug.Log ("ha obstaculos aqui");
			Debug.Log ("pos (" + gridPosition.x + "," + gridPosition.y + "," + gridPosition.z + ")");
				} else {
			Debug.Log ("pos (" + gridPosition.x + "," + gridPosition.y + "," + gridPosition.z + ")");
				}		
		*/
		Debug.Log ("pos (" + gridPosition.x + "," + gridPosition.y + "," + gridPosition.z + ")");
	}
	
	void OnMouseExit() {
		//transform.renderer.material.color = Color.red;
	}
	
	
	void OnMouseDown() {
		GameManager.instance.moveCurrentPlayer (this);
		if (gridPosition.x == 0 && gridPosition.y == 0 && gridPosition.z == 2) {
						Debug.Log ("colidiu");
		
		}
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
