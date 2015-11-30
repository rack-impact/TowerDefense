using UnityEngine;
using System.Collections;

public class Result : MonoBehaviour {

	private GameObject abc;
	private int sum;

	// Use this for initialization
	void Start () {
	
		abc=GameObject.Find("abc");
//		for(int i=0;i<10;i++)
//		{
//			for(int j=0;j<10;j++)
//			{
//				sum+=abc.GetComponent<InstianteMasu>().status[i][j].Cost();
//			}
//		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void result(){

		Debug.Log(abc.GetComponent<InstianteMasu>().sum);
	}
}
