using UnityEngine;
using System.Collections;

public class GameHP : MonoBehaviour {

	public int HP;
	private GameObject text;

	// Use this for initialization
	void Start () {
	
		text=GameObject.Find("Money");
		HP=10;

	}
	
	// Update is called once per frame
	void Update () {
	
		if(HP<=0){
			Application.LoadLevel("GameOver");
		}

	}
	void OnTriggerEnter2D(Collider2D col) {
		if(col.gameObject.tag=="Enemy"){


			HP--;
			Destroy(col.gameObject);
			text.GetComponent<Player>().Money-=100;
			//			transform.position+=col.transform.position*Time.deltaTime;
			
		}
	}

}
