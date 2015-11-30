using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour {

	public GameObject bullet;
	public float insTime;
	public GameObject teki;
	public GameObject bullet2;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	




	}
	void OnTriggerStay2D(Collider2D col) {
		if(gameObject.name=="Bill(Clone)"){
		if(col.gameObject.tag=="Enemy"){
				teki=col.gameObject;
				Debug.Log("敵発見");

				insTime+=Time.deltaTime;
			if(insTime>1.5f){
				bullet2=(Instantiate(bullet,gameObject.transform.position,Quaternion.identity))as GameObject;
					bullet2.GetComponent<Bullet>().shop=this.gameObject;
					insTime=0;
				}
			}
		}
			if(gameObject.name=="Shop(Clone)"){
				if(col.gameObject.tag=="Enemy"){
					teki=col.gameObject;
					Debug.Log("敵発見");
					insTime+=Time.deltaTime;
					if(insTime>1.25f){
					bullet2=(Instantiate(bullet,gameObject.transform.position,Quaternion.identity))as GameObject;
					bullet2.GetComponent<Bullet>().shop=this.gameObject;
					insTime=0;
					}
				}
		}
		if(gameObject.name=="bigBuilding(Clone)"){
					if(col.gameObject.tag=="Enemy"){
						teki=col.gameObject;
						Debug.Log("敵発見");
						insTime+=Time.deltaTime;
						if(insTime>1){
					bullet2=(Instantiate(bullet,gameObject.transform.position,Quaternion.identity))as GameObject;
					bullet2.GetComponent<Bullet>().shop=this.gameObject;
							insTime=0;
				}
			}
		}

	}
	
}
