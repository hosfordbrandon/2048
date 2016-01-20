using UnityEngine;
using System.Collections;

public class Tiles : MonoBehaviour {

	public int value;
	public float speed = 60;

	private Rigidbody2D rBody;
	private BoxCollider2D GOcollider;
	private bool notCD = true;
	// Use this for initialization
	void Start () {
		rBody = gameObject.GetComponent<Rigidbody2D>();
		GOcollider = gameObject.GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if(Input.GetKey(KeyCode.UpArrow)){
			GOcollider.enabled = false;
			RaycastHit2D rayHit = Physics2D.Raycast(transform.position+new Vector3(0.5f,0.5f,0),Vector2.up);
			Debug.DrawRay(transform.position+new Vector3(0.5f,0.5f,0), Vector2.up,Color.red);
			GOcollider.enabled = true;
			move(rayHit,Vector2.up);
		}


		else if(Input.GetKey(KeyCode.DownArrow)){
			GOcollider.enabled = false;
			RaycastHit2D rayHit = Physics2D.Raycast(transform.position+new Vector3(0.5f,0.5f,0),Vector2.down);
			Debug.DrawRay(transform.position+new Vector3(0.5f,0.5f,0), Vector2.down,Color.red);
			GOcollider.enabled = true;
			move(rayHit,Vector2.down);
		}


		if(Input.GetKey(KeyCode.LeftArrow)){
			GOcollider.enabled = false;
			RaycastHit2D rayHit = Physics2D.Raycast(transform.position+new Vector3(0.5f,0.5f,0),Vector2.left);
			Debug.DrawRay(transform.position+new Vector3(0.5f,0.5f,0), Vector2.left,Color.red);
			GOcollider.enabled = true;
			move(rayHit,Vector2.left);
		}


		if(Input.GetKey(KeyCode.RightArrow)){
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
				Debug.Log("SAME VALUE");
			}
		}

	}
}
