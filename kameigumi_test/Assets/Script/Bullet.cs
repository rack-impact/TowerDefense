using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public GameObject shop;
	private GameObject target;
	private Vector3 vec;

	// Use this for initialization
	void Start () {
		System.Collections.Generic.List<GameObject> a = new System.Collections.Generic.List<GameObject>();
		a.Add(null);
		target = shop.GetComponent<Shot>().teki;

	}
	
	// Update is called once per frame
	void Update () {


		transform.position = Vector2.MoveTowards(transform.position, new Vector2(target.transform.position.x, transform.position.y), 5 * Time.deltaTime);
	
	}
	void OnTriggerEnter2D(Collider2D col) {
			if(col.gameObject.tag=="Enemy"){
			col.GetComponent<TekiStatus>().HP-=5;
			Destroy(gameObject);
//			transform.position+=col.transform.position*Time.deltaTime;

		}
	}
}
