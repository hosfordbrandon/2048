﻿using UnityEngine;
using System.Collections;

public class Tiles : MonoBehaviour {

	public int value;
	public float speed = 60;

	private Rigidbody2D rBody;
	private BoxCollider2D GOcollider;
	private bool notCD = true;

	private GameObject[] tiles;
	// Use this for initialization
	void Start () {
		rBody = gameObject.GetComponent<Rigidbody2D>();
		GOcollider = gameObject.GetComponent<BoxCollider2D>();
		tiles = GameObject.Find("GM").GetComponent<BoardManager>().tiles;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.UpArrow)){
			GOcollider.enabled = false;
			RaycastHit2D rayHit = Physics2D.Raycast(transform.position+new Vector3(0.5f,0.5f,0),Vector2.up);
			Debug.DrawRay(transform.position+new Vector3(0.5f,0.5f,0), Vector2.up,Color.red);
			GOcollider.enabled = true;
			move(rayHit,Vector2.up);
		}


		else if(Input.GetKeyDown(KeyCode.DownArrow)){
			GOcollider.enabled = false;
			RaycastHit2D rayHit = Physics2D.Raycast(transform.position+new Vector3(0.5f,0.5f,0),Vector2.down);
			Debug.DrawRay(transform.position+new Vector3(0.5f,0.5f,0), Vector2.down,Color.red);
			GOcollider.enabled = true;
			move(rayHit,Vector2.down);
		}


		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			GOcollider.enabled = false;
			RaycastHit2D rayHit = Physics2D.Raycast(transform.position+new Vector3(0.5f,0.5f,0),Vector2.left);
			Debug.DrawRay(transform.position+new Vector3(0.5f,0.5f,0), Vector2.left,Color.red);
			GOcollider.enabled = true;
			move(rayHit,Vector2.left);
		}


		if(Input.GetKeyDown(KeyCode.RightArrow)){
			GOcollider.enabled = false;
			RaycastHit2D rayHit = Physics2D.Raycast(transform.position+new Vector3(0.5f,0.5f,0),Vector2.right);
			Debug.DrawRay(transform.position+new Vector3(0.5f,0.5f,0), Vector2.right,Color.red);
			GOcollider.enabled = true;
			move(rayHit,Vector2.right);
		}
	}

	void move(RaycastHit2D ray, Vector2 direction){
		if(direction == Vector2.up){
			transform.position = new Vector3(transform.position.x,transform.position.y+ray.distance-0.5f,0f);
		}
		if(direction == Vector2.down){
			transform.position = new Vector3(transform.position.x,transform.position.y-ray.distance+0.5f,0f);
		}
		if(direction == Vector2.right){
			transform.position = new Vector3(transform.position.x+ray.distance-0.5f,transform.position.y,0f);
		}
		if(direction == Vector2.left){
			transform.position = new Vector3(transform.position.x-ray.distance+0.5f,transform.position.y,0f);
		}

		if(ray.collider.gameObject.tag=="Tile"){
			if(ray.collider.gameObject.GetComponent<Tiles>().value == value){
				GameObject toInstant;
				for(int i = 0; i < tiles.Length;i++){
					if(tiles[i].gameObject.name==gameObject.name){
						toInstant = tiles[i+1];
						combine(ray.collider.gameObject,toInstant);
					}
				}
				Debug.Log("SAME VALUE");
			}
		}

	}

	void combine(GameObject hit,GameObject target){
		Vector3 position = hit.transform.position;
		GameObject.Destroy(hit);
		GameObject.Destroy(gameObject);
		GameObject instant = Instantiate(target,position,Quaternion.identity) as GameObject;
	}
}
