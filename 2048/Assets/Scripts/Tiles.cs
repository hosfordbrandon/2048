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
			Debug.Log(rayHit.collider.gameObject.name);
			move(rayHit,Vector2.up);
		}


		else if(Input.GetKey(KeyCode.DownArrow)){
			GOcollider.enabled = false;
			RaycastHit2D rayHit = Physics2D.Raycast(transform.position+new Vector3(0.5f,0.5f,0),Vector2.down);
			Debug.DrawRay(transform.position+new Vector3(0.5f,0.5f,0), Vector2.down,Color.red);
			GOcollider.enabled = true;
			Debug.Log(rayHit.collider.gameObject.name);
			move(rayHit,Vector2.down);
		}


		if(Input.GetKey(KeyCode.LeftArrow)){
			GOcollider.enabled = false;
			RaycastHit2D rayHit = Physics2D.Raycast(transform.position+new Vector3(0.5f,0.5f,0),Vector2.left);
			Debug.DrawRay(transform.position+new Vector3(0.5f,0.5f,0), Vector2.up,Color.red);
			GOcollider.enabled = true;
			Debug.Log(rayHit.collider.gameObject.name);
		}


		if(Input.GetKey(KeyCode.RightArrow)){
			GOcollider.enabled = false;
			RaycastHit2D rayHit = Physics2D.Raycast(transform.position+new Vector3(0.5f,0.5f,0),Vector2.right);
			Debug.DrawRay(transform.position+new Vector3(0.5f,0.5f,0), Vector2.right,Color.red);
			GOcollider.enabled = true;
			Debug.Log(rayHit.collider.gameObject.name);
		}
	}

	void move(RaycastHit2D ray, Vector2 direction){
		Debug.Log(ray.distance);
		if(direction == Vector2.up){
			transform.position = new Vector3(transform.position.x,transform.position.y+ray.distance-0.5f,0f);
		}
		if(direction == Vector2.down){
			transform.position = new Vector3(transform.position.x,transform.position.y-ray.distance+0.5f,0f);
		}
	}
}
