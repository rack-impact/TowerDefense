using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InstantiateBill : MonoBehaviour {

	public GameObject[] instante;
	public int number;
	private GameObject text;

	// Use this for initialization
	void Start () {
		text=GameObject.Find("Money");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			
			Vector3    aTapPoint   = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);
			
			if (aCollider2d) {
				GameObject obj = aCollider2d.transform.gameObject;
				Vector3 instantiateSpace=aCollider2d.transform.position;
				if(aCollider2d.tag!="road")
				{
				Instantiate(instante[number],new Vector3(instantiateSpace.x,instantiateSpace.y,0),Quaternion.identity);
					if(number==0){
					text.GetComponent<Player>().Money-=50;
					}
					if(number==1){
						text.GetComponent<Player>().Money-=100;
					}
					if(number==2){
						text.GetComponent<Player>().Money-=150;
					}

					Debug.Log(obj.name);
				}
			}
		}	
	}
}
