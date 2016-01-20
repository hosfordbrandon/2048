using UnityEngine;
using System.Collections.Generic;

public class BoardManager : MonoBehaviour {

	public int size =4;
	public GameObject[] tiles;

	private List<Vector3> gridPositions = new List<Vector3>();

	void Start () {
		InitList();
		Place(Tiles[0]);
		Place(Tiles[0]);

	}

	void InitList(){
		gridPositions.Clear();

		for(int i = 0; i<size;i++){
			for(int j = 0; j<size;j++){
				gridPositions.Add(new Vector3(i,j,0f));
			}
		}
	}


	void Place(GameObject tile){
		List <Vector3> temp = gridPositions;

		int pos = UnityEngine.Random.Range(0, gridPositions.Count);
		Debug.Log("This is the position! "+gridPositions[pos]);
		GameObject instant = Instantiate(tile,gridPositions[pos],Quaternion.identity) as GameObject;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
