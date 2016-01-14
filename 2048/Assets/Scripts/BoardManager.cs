using UnityEngine;
using System.Collections;

public class BoardManager : MonoBehaviour {

	public int[][] board= new int[4][4];



	void Start () {
		int startX = UnityEngine.Random.Range(0,5);


		for(int i =0;i<board.Length;i++){
			for(int j =0; j<board[i].Length;j++){
				board[i][j] = 0;
			}
		}


	}
	


	// Update is called once per frame
	void Update () {
	
	}
}
