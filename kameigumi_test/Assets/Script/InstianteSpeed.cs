using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InstianteSpeed : MonoBehaviour {

    public float numberChange;
    private GameObject gameManeger;
    public float maxNumber=2;
    private float nowNumber;
    private float changedNumber;

	// Use this for initialization
	void Start () {

        gameManeger=GameObject.Find("GameManegar");
        GetComponent<Slider>().maxValue=maxNumber;
        nowNumber = gameManeger.GetComponent<Idou>().insTime;
    }
	
	// Update is called once per frame
	void Update () {

        numberChange = GetComponent<Slider>().value;
        changedNumber = nowNumber - numberChange;
        gameManeger.GetComponent<Idou>().insTime=changedNumber;

    }
}
