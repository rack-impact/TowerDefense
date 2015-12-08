using UnityEngine;
using System.Collections;
using System;
using System.Linq;

public class Result : MonoBehaviour {

	private TowerGenerator manager;
	private int sum;
    private GameObject textMoney;

	// Use this for initialization
	void Start () {
        textMoney = GameObject.Find("Money");
        manager = GameObject.Find("GameManager").GetComponent<TowerGenerator>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

	public void result(){

        for (int j = 0; j < manager.nowTower.Count; j++)
        {
            sum += manager.nowTower[j].Cost();
        }
        Debug.Log("一日の経費です"+sum);
        textMoney.GetComponent<MoneyManager>().Money -= sum;
	}
}
