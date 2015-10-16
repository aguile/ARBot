using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Materials3 : MonoBehaviour {
	public static Materials3 instance;

	// Use this for initialization

	
	//public char[] function1;
	
	public GameObject TilePrefab;
	//public GameObject Tile2Prefab;


	public int obstaclePos0x,obstaclePos0y, obstaclePos0z  = 0;
	public int obstaclePos1x,obstaclePos1y, obstaclePos1z  = 0;
	public int obstaclePos2x,obstaclePos2y, obstaclePos2z  = 0;
	public int obstaclePos3x,obstaclePos3y, obstaclePos3z  = 0;
	public int mapSize = 11;


	

	

	List <List<Tile>> obstacles = new List<List<Tile>>();
	List <List<Tile>> map = new List<List<Tile>>();
	//List <List<Tile2>> finish = new List<List<Tile2>>();


	
	void Awake() {
		instance = this;
		
	}
	
	// Use this for initialization
	void Start () {		

		generateObstacle0();
		generateObstacle1 ();
		generateObstacle2 ();
		generateObstacle3 ();
		//generateFinish ();

		GuiScript[] arr = GetComponents<GuiScript>();
		Debug.Log (arr);
	}
	
	// Update is called once per frame
	void Update () {
		

	}
	

	


	
	void generateObstacle0() {
		map = new List<List<Tile>>();
		for (int i = 0; i < 1; i++) {
			List <Tile> row = new List<Tile>();
			for (int j = 0; j < 4; j++) {
				Tile tile = ((GameObject)Instantiate(TilePrefab, new Vector3(i - Mathf.Floor(mapSize/2) + obstaclePos0x ,obstaclePos0y, -j -obstaclePos0z + Mathf.Floor(mapSize/2)), Quaternion.Euler(new Vector3()))).GetComponent<Tile>();
				tile.gridPosition = new Vector3(i, j , obstaclePos0y);
				row.Add (tile);
			}
			map.Add(row);
		}

		for (int i = 0; i < 1; i++) {
			List <Tile> row = new List<Tile>();
			for (int j = 0; j < 3; j++) {
				Tile tile = ((GameObject)Instantiate(TilePrefab, new Vector3(1 + i - Mathf.Floor(mapSize/2) + obstaclePos0x ,obstaclePos0y, -1 -j -obstaclePos0z + Mathf.Floor(mapSize/2)), Quaternion.Euler(new Vector3()))).GetComponent<Tile>();
				tile.gridPosition = new Vector3(i, j , obstaclePos0y);
				row.Add (tile);
			}
			map.Add(row);
		}

		for (int i = 0; i < 1; i++) {
			List <Tile> row = new List<Tile>();
			for (int j = 0; j < 4; j++) {
				Tile tile = ((GameObject)Instantiate(TilePrefab, new Vector3(3 + i - Mathf.Floor(mapSize/2) + obstaclePos0x ,obstaclePos0y, -j -obstaclePos0z + Mathf.Floor(mapSize/2)), Quaternion.Euler(new Vector3()))).GetComponent<Tile>();
				tile.gridPosition = new Vector3(i, j , obstaclePos0y);
				row.Add (tile);
			}
			map.Add(row);
		}

		for (int i = 0; i < 2; i++) {
			List <Tile> row = new List<Tile>();
			for (int j = 0; j < 1; j++) {
				Tile tile = ((GameObject)Instantiate(TilePrefab, new Vector3(1 + i - Mathf.Floor(mapSize/2) + obstaclePos0x ,obstaclePos0y, -j -obstaclePos0z + Mathf.Floor(mapSize/2)), Quaternion.Euler(new Vector3()))).GetComponent<Tile>();
				tile.gridPosition = new Vector3(i, j , obstaclePos0y);
				row.Add (tile);
			}
			map.Add(row);
		}

		for (int i = 0; i < 2; i++) {
			List <Tile> row = new List<Tile>();
			for (int j = 0; j < 1; j++) {
				Tile tile = ((GameObject)Instantiate(TilePrefab, new Vector3(1 + i - Mathf.Floor(mapSize/2) + obstaclePos0x ,obstaclePos0y, -j -obstaclePos0z + Mathf.Floor(mapSize/2)), Quaternion.Euler(new Vector3()))).GetComponent<Tile>();
				tile.gridPosition = new Vector3(i, j , obstaclePos0y);
				row.Add (tile);
			}
			map.Add(row);
		}


	}


	void generateObstacle1() {
		map = new List<List<Tile>>();
		for (int i = 0; i < 2; i++) {
			List <Tile> row = new List<Tile>();
			for (int j = 0; j < 2; j++) {
				Tile tile = ((GameObject)Instantiate(TilePrefab, new Vector3(i - Mathf.Floor(mapSize/2) + obstaclePos1x ,obstaclePos1y, -2 -j -obstaclePos1z + Mathf.Floor(mapSize/2)), Quaternion.Euler(new Vector3()))).GetComponent<Tile>();
				tile.gridPosition = new Vector3(i, j , obstaclePos1y);
				row.Add (tile);
			}
			map.Add(row);
		}
		
		for (int i = 0; i < 1; i++) {
			List <Tile> row = new List<Tile>();
			for (int j = 0; j < 4; j++) {
				Tile tile = ((GameObject)Instantiate(TilePrefab, new Vector3( i - Mathf.Floor(mapSize/2) + obstaclePos1x ,obstaclePos1y, -j -obstaclePos1z + Mathf.Floor(mapSize/2)), Quaternion.Euler(new Vector3()))).GetComponent<Tile>();
				tile.gridPosition = new Vector3(i, j , obstaclePos1y);
				row.Add (tile);
			}
			map.Add(row);
		}
		
		for (int i = 0; i < 1; i++) {
			List <Tile> row = new List<Tile>();
			for (int j = 0; j < 4; j++) {
				Tile tile = ((GameObject)Instantiate(TilePrefab, new Vector3(3 + i - Mathf.Floor(mapSize/2) + obstaclePos1x ,obstaclePos1y, -j -obstaclePos1z + Mathf.Floor(mapSize/2)), Quaternion.Euler(new Vector3()))).GetComponent<Tile>();
				tile.gridPosition = new Vector3(i, j , obstaclePos1y);
				row.Add (tile);
			}
			map.Add(row);
		}
		
		for (int i = 0; i < 2; i++) {
			List <Tile> row = new List<Tile>();
			for (int j = 0; j < 1; j++) {
				Tile tile = ((GameObject)Instantiate(TilePrefab, new Vector3(1 + i - Mathf.Floor(mapSize/2) + obstaclePos1x ,obstaclePos1y, -j -obstaclePos1z + Mathf.Floor(mapSize/2)), Quaternion.Euler(new Vector3()))).GetComponent<Tile>();
				tile.gridPosition = new Vector3(i, j , obstaclePos1y);
				row.Add (tile);
			}
			map.Add(row);
		}
		
		for (int i = 0; i < 2; i++) {
			List <Tile> row = new List<Tile>();
			for (int j = 0; j < 1; j++) {
				Tile tile = ((GameObject)Instantiate(TilePrefab, new Vector3(1 + i - Mathf.Floor(mapSize/2) + obstaclePos1x ,obstaclePos1y, -j -obstaclePos1z + Mathf.Floor(mapSize/2)), Quaternion.Euler(new Vector3()))).GetComponent<Tile>();
				tile.gridPosition = new Vector3(i, j , obstaclePos1y);
				row.Add (tile);
			}
			map.Add(row);
		}









	}



	void generateObstacle2() {
				map = new List<List<Tile>> ();
				for (int i = 0; i < 1; i++) {
						List <Tile> row = new List<Tile> ();
						for (int j = 0; j < 2; j++) {
								Tile tile = ((GameObject)Instantiate (TilePrefab, new Vector3 (1 + i - Mathf.Floor (mapSize / 2) + obstaclePos2x, obstaclePos2y, -2 - j - obstaclePos2z + Mathf.Floor (mapSize / 2)), Quaternion.Euler (new Vector3 ()))).GetComponent<Tile> ();
								tile.gridPosition = new Vector3 (i, j, obstaclePos1y);
								row.Add (tile);
						}
						map.Add (row);
				}
		
				for (int i = 0; i < 4; i++) {
						List <Tile> row = new List<Tile> ();
						for (int j = 0; j < 1; j++) {
								Tile tile = ((GameObject)Instantiate (TilePrefab, new Vector3 (i - Mathf.Floor (mapSize / 2) + obstaclePos2x, obstaclePos2y, -j - obstaclePos2z + Mathf.Floor (mapSize / 2)), Quaternion.Euler (new Vector3 ()))).GetComponent<Tile> ();
								tile.gridPosition = new Vector3 (i, j, obstaclePos1y);
								row.Add (tile);
						}
						map.Add (row);
				}
		
				for (int i = 0; i < 1; i++) {
						List <Tile> row = new List<Tile> ();
						for (int j = 0; j < 3; j++) {
								Tile tile = ((GameObject)Instantiate (TilePrefab, new Vector3 (3 + i - Mathf.Floor (mapSize / 2) + obstaclePos2x, obstaclePos2y, -1 -j - obstaclePos2z + Mathf.Floor (mapSize / 2)), Quaternion.Euler (new Vector3 ()))).GetComponent<Tile> ();
								tile.gridPosition = new Vector3 (i, j, obstaclePos1y);
								row.Add (tile);
						}
						map.Add (row);
				}


		}



	void generateObstacle3() {
		map = new List<List<Tile>> ();
		for (int i = 0; i < 1; i++) {
			List <Tile> row = new List<Tile> ();
			for (int j = 0; j < 4; j++) {
				Tile tile = ((GameObject)Instantiate (TilePrefab, new Vector3 (2 + i - Mathf.Floor (mapSize / 2) + obstaclePos3x, obstaclePos3y, - j - obstaclePos3z + Mathf.Floor (mapSize / 2)), Quaternion.Euler (new Vector3 ()))).GetComponent<Tile> ();
				tile.gridPosition = new Vector3 (i, j, obstaclePos1y);
				row.Add (tile);
			}
			map.Add (row);
		}
		
		for (int i = 0; i < 1; i++) {
			List <Tile> row = new List<Tile> ();
			for (int j = 0; j < 4; j++) {
				Tile tile = ((GameObject)Instantiate (TilePrefab, new Vector3 (3 + i - Mathf.Floor (mapSize / 2) + obstaclePos3x, obstaclePos3y, - j - obstaclePos3z + Mathf.Floor (mapSize / 2)), Quaternion.Euler (new Vector3 ()))).GetComponent<Tile> ();
				tile.gridPosition = new Vector3 (i, j, obstaclePos1y);
				row.Add (tile);
			}
			map.Add (row);
		}
		
		for (int i = 0; i < 1; i++) {
			List <Tile> row = new List<Tile> ();
			for (int j = 0; j < 1; j++) {
				Tile tile = ((GameObject)Instantiate (TilePrefab, new Vector3 (4 + i - Mathf.Floor (mapSize / 2) + obstaclePos3x, obstaclePos3y, -3 -j - obstaclePos3z + Mathf.Floor (mapSize / 2)), Quaternion.Euler (new Vector3 ()))).GetComponent<Tile> ();
				tile.gridPosition = new Vector3 (i, j, obstaclePos1y);
				row.Add (tile);
			}
			map.Add (row);
		}
		
		
	}



	



}
