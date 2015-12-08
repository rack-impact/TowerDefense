using UnityEngine;
using System.Collections;

public class ButtomManager : MonoBehaviour {

    private GameObject manager;
    private GameObject hopUp;
    public float timeHopUp;
    private bool _hopUp=true;
    private bool _pause = true;

    // Use this for initialization
    void Start()
    {
        manager = GameObject.Find("GameManager");
        hopUp = GameObject.Find("HopUpZone");
        timeHopUp = 0;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NormalTSW()
    {
        manager.GetComponent<TowerGenerator>().number = 0;
        manager.GetComponent<TowerGenerator>()._generate = true;
    }
    public void FastTSW()
    {
        manager.GetComponent<TowerGenerator>().number = 1;
        manager.GetComponent<TowerGenerator>()._generate = true;
    }

    public void PowerTSW()
    {
        manager.GetComponent<TowerGenerator>().number = 2;
        manager.GetComponent<TowerGenerator>()._generate = true;
    }
    public void HopUp()
    {
        if (_hopUp)
        {
            hopUp.GetComponent<RectTransform>().transform.position = Vector3.Lerp(hopUp.transform.position, new Vector3(-3f, 1.9f, 0), 1);
            _hopUp = false;
        }
        else
        {
            hopUp.GetComponent<RectTransform>().transform.position = Vector3.Lerp(hopUp.transform.position, new Vector3(2.2f, 1.9f, 0), 1);
            _hopUp = true;
        }
    }
    public void Pause()
    {
        if (_pause)
        {
            PauseSystem.Pause();
            _pause = false;
        }
        else
        {
            PauseSystem.Resume();
            _pause = true;
        }
    }

}
