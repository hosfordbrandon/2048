using UnityEngine;
using System.Collections.Generic;

public class BoardManager : MonoBehaviour {

	public int size =4;
	public GameObject[] tiles;
	public Camera cam;

	private List<Vector3> gridPositions = new List<Vector3>();

	void Start () {
		InitList();
		Place(tiles[0]);
		Place(tiles[0]);
		//hello

	}

	void InitList(){
		gridPositions.Clear();

		for(int i = 0; i<size;i++){
			for(int j = 0; j<size;j++){
				gridPositions.Add(new Vector3(i,j,0f));
			}
		}
	}


	void ScanGrid(){
		gridPositions.Clear();
		
		for(int i = 0; i<size;i++){
			for(int j = 0; j<size;j++){
				RaycastHit2D hit;
				Ray ray = cam.ScreenPointToRay(new Vector2(i,j));
				if(Physics2D.Raycast(ray, out hit)){
					GameObject objHit = hit.collider.gameObject;
					if(objHit.tag!="Tile"){
						gridPositions.Add(new Vector3(i,j,0f));
					}
				}
			}
		}
		Debug.Log(gridPositions);
	}

	void Place(GameObject tile){
		List <Vector3> temp = gridPositions;

		int pos = UnityEngine.Random.Range(0, gridPositions.Count);
		Debug.Log("This is the position! "+gridPositions[pos]);
		GameObject instant = Instantiate(tile,gridPositions[pos],Quaternion.identity) as GameObject;
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			ScanGrid();
		}
	}
}
