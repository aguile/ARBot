using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
	public static GameManager instance;

	//public char[] function1;

	public GameObject TilePrefab;
	public GameObject Tile2Prefab;
	public GameObject UserPlayerPrefab;
	public GameObject AIPlayerPrefab;

	public int mapSize = 11;





	
	List <List<Tile>> map = new List<List<Tile>>();
	//List <List<Tile2>> obstacles = new List<List<Tile2>>();
	List <Player> players = new List<Player>();
	int currentPlayerIndex = 0;


	//public int obstaclePos0x,obstaclePos0y, obstaclePos0z  = 0;




	void Awake() {
		instance = this;

	}
	
	// Use this for initialization
	void Start () {		
		generateMap();
		//generateObstacle0();

		generatePlayers();
		GuiScript[] arr = GetComponents<GuiScript>();
		Debug.Log (arr);
	}
	
	// Update is called once per frame
	void Update () {
		
		players[currentPlayerIndex].TurnUpdate();
	}
	
	public void nextTurn() {
		if (currentPlayerIndex + 1 < players.Count) {
			currentPlayerIndex++;
		} else {
			currentPlayerIndex = 0;
		}
	}
	
	public void moveCurrentPlayer(Tile destTile) {
		players[currentPlayerIndex].moveDestination = destTile.transform.position + 1.5f * Vector3.up;
		//players[currentPlayerIndex].rigidbody.MovePosition(rigidbody.position);


	}

	public void moveCommandPlayer(Vector3 playerPosition) {

		players[currentPlayerIndex].transform.localPosition = playerPosition;
		//players[currentPlayerIndex].moveDestination = playerPosition;
		//players[currentPlayerIndex].moveDestination = playerPosition;
		//players[currentPlayerIndex].transform.position = playerPosition;
	}



	void generateMap() {
		map = new List<List<Tile>>();
		for (int i = 0; i < mapSize; i++) {
			List <Tile> row = new List<Tile>();
			for (int j = 0; j < mapSize; j++) {
				Tile tile = ((GameObject)Instantiate(TilePrefab, new Vector3(i - Mathf.Floor(mapSize/2),0, -j + Mathf.Floor(mapSize/2)), Quaternion.Euler(new Vector3()))).GetComponent<Tile>();
				tile.gridPosition = new Vector3(i, j , 0);
				row.Add (tile);
			}
			map.Add(row);
		}
	}
// OBSTACULOS
//
//
	/*
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
	}
	*/





	
	void generatePlayers() {
		UserPlayer player;
		
		player = ((GameObject)Instantiate(UserPlayerPrefab, new Vector3( - Mathf.Floor(mapSize/2),1.5f, -9 + Mathf.Floor(mapSize/2)), Quaternion.Euler(new Vector3()))).GetComponent<UserPlayer>();

		player.name = "Player";
		//player = UserPlayer;

		players.Add(player);
		
		//player = ((GameObject)Instantiate(UserPlayerPrefab, new Vector3((mapSize-1) - Mathf.Floor(mapSize/2),1.5f, -(mapSize-1) + Mathf.Floor(mapSize/2)), Quaternion.Euler(new Vector3()))).GetComponent<UserPlayer>();
		
		//players.Add(player);
				
		//player = ((GameObject)Instantiate(UserPlayerPrefab, new Vector3(4 - Mathf.Floor(mapSize/2),1.5f, -4 + Mathf.Floor(mapSize/2)), Quaternion.Euler(new Vector3()))).GetComponent<UserPlayer>();
		
		//players.Add(player);

		AIPlayer aiplayer = ((GameObject)Instantiate(AIPlayerPrefab, new Vector3(6 - Mathf.Floor(mapSize/2),1.0f, -9 + Mathf.Floor(mapSize/2)), Quaternion.Euler(new Vector3()))).GetComponent<AIPlayer>();
		
		players.Add(aiplayer);

	}



}
