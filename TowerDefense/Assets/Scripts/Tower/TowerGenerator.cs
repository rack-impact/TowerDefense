using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TowerGenerator : MonoBehaviour
{
    public GameObject[] instante;
    public int number;
    private GameObject text;
    private GameObject towerBuy;
    public List<TowerBase> nowTower = new List<TowerBase>();
    private GameObject pause;
    private RaycastHit2D hit;
    public bool _generate;

    // Use this for initialization
    void Start()
    {
        text = GameObject.Find("Money");
        pause = GameObject.Find("Pause");

    }
    // Update is called once per frame
    //ここではタワーを建てるときの処理をしています。
    //レイを飛ばしてそれが"Masu"のタグと_generateのブールがtrueのときにお金があれば建設出来るようにしています。
    //_generateはButtonManagerにあります。
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 aTapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);
            if (aCollider2d)
            {
                int layerMask =~(1 << LayerMask.NameToLayer("Tower"));
                hit = Physics2D.Raycast(aTapPoint, -Vector2.up, 100, layerMask);
                if (hit)
                {
                    //GameObject obj = hit.transform.gameObject;
                    Vector3 instantiateSpace = hit.transform.position;
                    if (hit.transform.tag=="Masu"&&_generate)
                    {
                        towerBuy = Instantiate(instante[number], instantiateSpace, Quaternion.identity) as GameObject;
                        towerBuy.transform.parent = pause.transform;
                        _generate = false;
                        if (towerBuy.GetComponent<TowerBase>().Cost() < text.GetComponent<MoneyManager>().Money)
                        {
                            if (number == 0)
                            {
                                nowTower.Add(new NormalTower());
                                text.GetComponent<MoneyManager>().Money -= towerBuy.GetComponent<NormalTower>().Cost();
                            }
                            if (number == 1)
                            {
                                nowTower.Add(new FastTower());
                                text.GetComponent<MoneyManager>().Money -= towerBuy.GetComponent<FastTower>().Cost();
                            }
                            if (number == 2)
                            {
                                nowTower.Add(new PowerTower());
                                text.GetComponent<MoneyManager>().Money -= towerBuy.GetComponent<PowerTower>().Cost();
                            }
                        }
                    }
                }
            }
        }
    }
}
