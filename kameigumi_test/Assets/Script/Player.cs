using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	public int Money;
	private Text text;
	private Vector3 EnemyPos;
	private float kyori;

	// Use this for initialization
	void Start () {
		Money=100;
		text=GetComponent<Text>();
//		EnemyPos=GameObject.Find("Enemy").GetComponent<Transform>().position;
	}
	
	// Update is called once per frame
	void Update () {
		text.text=Money.ToString();
        if (Money < 0)
        {
            //			styleState.textColor=Color.red;
        }
//		kyori = (EnemyPos - transform.position).magnitude;
//		if (kyori < 10) {
//			//攻撃
//		}
	}
}
