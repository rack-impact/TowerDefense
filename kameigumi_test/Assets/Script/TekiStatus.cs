using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TekiStatus : MonoBehaviour {

	public int HP;
	private GameObject text;
	
	// Use this for initialization
	void Start () {
	
		HP=2;
		text=GameObject.Find("Money");

	}
	
	// Update is called once per frame
	void Update () {
	
		if(HP<=0) {
			Destroy(gameObject);
			text.GetComponent<Player>().Money+=50;
		}
	}

}
