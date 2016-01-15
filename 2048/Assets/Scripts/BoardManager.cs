using UnityEngine;
using System.Collections.Generic;

public class BoardManager : MonoBehaviour {

	public int size =4;
	public GameObject[] tiles;

	private List<Vector3> gridPositions = new List<Vector3>();

	void Start () {
		InitList();
		Place(tiles[0]);

	}
	


	void InitList(){
		gridPositions.Clear();

		for(int i = 0; i<size+1;i++){
			for(int j = 0; j<size+1;j++){
				gridPositions.Add(new Vector3(i,j,0f));
			}
		}
	}
	void Place(GameObject tile){
		//int pos = UnityEngine.Random.Range(0, gridPositions.)
	}

	// Update is called once per frame
	void Update () {
	
	}
}
