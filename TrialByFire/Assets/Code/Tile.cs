using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	public Sprite red1;
	public Sprite red2;
	public Sprite red3;

	private int tileNum;
	public bool isTarget;

	public SpriteRenderer renderer;
	private TileGenerator gen;
	// Use this for initialization
	void Start () {
		gen = gameObject.GetComponentInParent<TileGenerator>();
		//renderer = gameObject.GetComponentInParent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D( Collider2D other ){
		if(isTarget){
			Debug.Log("Test");
			if(other.gameObject.name == "Player"){
				Debug.Log("Player has touched target tile");
				gen.TargetTileTouched();
			}
		}
	}
	public void SetTileNum( int n ){ tileNum = n; }
	public void IsTargetTile( bool v ){ isTarget = v; }
	public void SetTileType( int whichSprite){ //takes an int representing which sprite to show in the renderer
		if(whichSprite > 0 || whichSprite < 4){
			switch(whichSprite){
				case 1: renderer.sprite = red1; break;
				case 2: renderer.sprite = red2; break;
				case 3: renderer.sprite = red3; break;
				default: break;
			}
		}
		else{
			Debug.Log("Invalid Sprite number sent to SetTileType!" + whichSprite.ToString());
			return;
		}
	}
}
