using UnityEngine;
using System.Collections;

public class TekiIdou : MonoBehaviour {

	public float speed=1;
	private Vector3 vec;
	private Vector3 vec2;


	// Use this for initialization
	void Start () {

		vec.y=-speed;
	}
	
	// Update is called once per frame
	void Update () {



//		if(transform.position.y>0){
//			vec.y-=speed*Time.deltaTime;
//			Debug.Log("した");
//		}
//		else if(transform.position.x>-3&&transform.position.x<2.4){
//			Debug.Log("右");
//			vec.y=0;
//			vec.x+=speed*Time.deltaTime;
//			vec2.x=vec.x;
//		}
//		else {
//			Debug.Log("した2");
//			vec.x=0;
//			vec.y-=speed*Time.deltaTime;
//		}
		transform.position+=vec*Time.deltaTime;
		if(transform.position.y<-11){
			Destroy(gameObject);
		}
	}
	void OnTriggerStay2D(Collider2D col) {
	
		if(col.gameObject.tag=="Up"){
			vec.x=0;
			vec.y=speed;
		}
		if(col.gameObject.tag=="Down"){
			vec.x=0;
			vec.y=-speed;
		}
		if(col.gameObject.tag=="Left"){
			vec.y=0;
			vec.x=-speed;
		}
		if(col.gameObject.tag=="Right"){
			vec.y=0;
			vec.x=speed;
		}

	
	}
}
