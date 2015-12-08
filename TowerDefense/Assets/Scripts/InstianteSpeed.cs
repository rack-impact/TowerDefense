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

        gameManeger=GameObject.Find("GameManager");
        GetComponent<Slider>().maxValue=maxNumber;
        nowNumber = gameManeger.GetComponent<GameManager>().insTime;
    }
	
	// Update is called once per frame
	void Update () {

        numberChange = GetComponent<Slider>().value;
        changedNumber = nowNumber - numberChange;
        gameManeger.GetComponent<GameManager>().insTime=changedNumber;

    }
}
