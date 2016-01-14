using UnityEngine;
using System.Collections.Generic;

public class BoardManager : MonoBehaviour {

	public int size =4;
	public GameObject[] tiles;

	private List<Vector3> gridPositions = new List<Vector3>();

	void Start () {
		InitList();

	}
	


	void InitList(){
		gridPositions.Clear();

		for(int i = 0; i<size+1;i++){
			for(int j = 0; j<size+1;j++){
				gridPositions.Add(new Vector3(i,j,0f));
			}
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
