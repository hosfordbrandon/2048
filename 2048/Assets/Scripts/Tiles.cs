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
			RaycastHit2D rayHit = Physics2D.Raycast(transform.position+new Vector3(0.5f,0,0),Vector2.up);
			Debug.DrawRay(transform.position+new Vector3(0.5f,0,0), Vector2.up,Color.red);
			GOcollider.enabled = true;
			Debug.Log(rayHit.collider.gameObject.name);
		}


	}


}
