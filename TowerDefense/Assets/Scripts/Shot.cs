using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shot : MonoBehaviour
{

    public GameObject bullet;
    public float insTime;
    private float shotTime;
    public GameObject teki;
    public GameObject bullet2;
    public List<GameObject> Enemy = new List<GameObject>();
    private GameObject pause;

    // Use this for initialization
    void Start()
    {
        shotTime = GetComponent<TowerBase>().ShotTime();
        pause=GameObject.Find("Pause");
    }

    // Update is called once per frame
    void Update()
    {
        insTime += Time.deltaTime;
        for (int i = 0; i < Enemy.Count; i++)
        {
            if (Enemy[i] == null)
            {
                Enemy.Remove(Enemy[i]);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //if(gameObject.name=="Bill(Clone)"){
        if (col.gameObject.tag == "Enemy")
        {
            Enemy.Add(col.gameObject);
            Debug.Log("敵発見");
        }
    }
        void OnTriggerStay2D(Collider2D col)
    {
        if (insTime > shotTime)
        {
            bullet2 = (Instantiate(bullet, gameObject.transform.position, Quaternion.identity)) as GameObject;
            bullet2.transform.parent = pause.transform;
            bullet2.GetComponent<Bullet>().tower = this.gameObject;
            insTime = 0;
        }
}
        //}
        //	if(gameObject.name=="Shop(Clone)"){
        //		if(col.gameObject.tag=="Enemy"){
        //			teki=col.gameObject;
        //			Debug.Log("敵発見");
        //			insTime+=Time.deltaTime;
        //			if(insTime>1.25f){
        //			bullet2=(Instantiate(bullet,gameObject.transform.position,Quaternion.identity))as GameObject;
        //			bullet2.GetComponent<Bullet>().shop=this.gameObject;
        //			insTime=0;
        //			}
        //		}
        //}
        //if(gameObject.name=="bigBuilding(Clone)"){
        //			if(col.gameObject.tag=="Enemy"){
        //				teki=col.gameObject;
        //				Debug.Log("敵発見");
        //				insTime+=Time.deltaTime;
        //				if(insTime>1){
        //			bullet2=(Instantiate(bullet,gameObject.transform.position,Quaternion.identity))as GameObject;
        //			bullet2.GetComponent<Bullet>().shop=this.gameObject;
        //					insTime=0;
        //		}
        //	}
        //}
    void OnTriggerExit2D(Collider2D col)
    {
        Enemy.Remove(col.gameObject);
    }
}
