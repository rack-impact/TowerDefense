using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    //private Text text;
    private Text DayCounter;
    public int maxCount;
    public float Count;
    //private int CountT;
    private int Day;
    private Slider slider;
    private GameObject manager;

    // Use this for initialization
    void Start () {
        //text = GetComponent<Text>();
        Count = 30;
        DayCounter = GameObject.Find("DayCounter").GetComponent<Text>();
        manager = GameObject.Find("GameManager");
        DayCounter.text = Day+1 + "日".ToString();
        slider = GameObject.Find("Timer").GetComponent<Slider>();
        slider.maxValue = maxCount;
        Day = 1;
    }
	
	// Update is called once per frame
	void Update () {
        Count -= Time.deltaTime;
        //CountT = (int)Count;
        slider.value = Count;
        //text.text = CountT.ToString();
        if (Count <= 0)
        {
            Debug.Log("次の日へ");
            Day += 1;
            DayCounter.text = Day+"日".ToString();
            manager.GetComponent<Result>().result();
            Count = 31.0f;
            //CountT = (int)Count;
            //text.text = CountT.ToString();
        }
    }
}
