using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TileGenerator : MonoBehaviour {
	public Tile[] tileList;
	public GameObject torch;

	private bool isPuzzleSolved = false;
	// Use this for initialization
	void Start () {
		int targetTile = (int)(Random.value * tileList.Length);
		int index = 0;


		foreach(Tile tile in tileList){
			tile.SetTileNum(index);
			if(Random.value > 0.5f){ tile.SetTileType(1); }
			else{ tile.SetTileType(3); }
			tile.IsTargetTile(index == targetTile);
			index++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TargetTileTouched(){
		//Drop Torch
		DropTorch();
		/*int targetTile = (int)(Random.value * tileList.Length);
		int index = 0;

		foreach(Tile tile in tileList){
			tile.IsTargetTile(index == targetTile);
			tile.SetTileType( 1 + (int)(Random.value * 3));
			index++;
		}*/
	}

	public void DropTorch(){
		torch.SetActive(true);
	}
}
