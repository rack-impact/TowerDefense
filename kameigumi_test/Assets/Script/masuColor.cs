using UnityEngine;
using System.Collections;

public class masuColor : MonoBehaviour {

	public SpriteRenderer rend;
//	private int i=0;
//	private int j=0;
	
	// Use this for initialization
	void Start () {
		rend=gameObject.GetComponent<SpriteRenderer>();
//		towers[0] = new Bill();
//		towers[1] = new Shop();
		
		//		int sum =0;
		//		for(int i=0;i<towers.Length;i++)
		//			sum+= towers[i].Cost();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseEnter(){
		rend.material.color = Color.red;
	}
	//	void OnMouseOver() {
	//		rend.material.color -= new Color(0.1F, 0, 0) * Time.deltaTime;
	//	}
	void OnMouseExit() {
		rend.material.color = Color.white;
	}
}
