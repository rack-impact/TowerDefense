using UnityEngine;
using System.Collections;

public class ButtomManegar : MonoBehaviour {

    private GameObject abc;
    private GameObject def;
    public float timeHopUp;
    private bool _hopUp=true;
    private bool _pause = true;

    // Use this for initialization
    void Start()
    {

        abc = GameObject.Find("GameManegar");
        def = GameObject.Find("HopUp");
        timeHopUp = 0;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BillSW()
    {

        abc.GetComponent<InstantiateBill>().number = 0;
        //		abc.GetComponent<InstianteMasu>().nameS=new Bill();

    }
    public void ShopSW()
    {

        abc.GetComponent<InstantiateBill>().number = 1;
        //		abc.GetComponent<InstianteMasu>().nameS=new Shop();

    }

    public void BigSW()
    {

        abc.GetComponent<InstantiateBill>().number = 2;
        //		abc.GetComponent<InstianteMasu>().nameS=new BigBuilding();

    }
    public void HopUp()
    {
        if (_hopUp)
        {
            def.GetComponent<RectTransform>().transform.position = Vector3.Lerp(def.transform.position, new Vector3(-2.5f, 1.9f, 0), 1);
            _hopUp = false;
        }
        else
        {
            def.GetComponent<RectTransform>().transform.position = Vector3.Lerp(def.transform.position, new Vector3(2f, 1.9f, 0), 1);
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
