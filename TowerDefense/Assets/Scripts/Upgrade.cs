using UnityEngine;
using System.Collections;

public class Upgrade : MonoBehaviour
{

    private RaycastHit2D hit;
    private GameObject oldSitei;
    private int _money;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 aTapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);
            if (aCollider2d)
            {
                int layerMask = (1 << LayerMask.NameToLayer("Tower"));
                hit = Physics2D.Raycast(aTapPoint, -Vector2.up, 100, layerMask);
                if (hit)
                {
                    _money = MoneyManager.Instance.Money;
                    Debug.Log(_money);
                    if (_money > hit.transform.GetComponent<TowerBase>().UpgraydeCost())
                    {
                        TowerJud();
                    }
                }
            }
        }
    }

    public void UPButton()
    {
        //var レイのヒットしたオブジェクトの情報 = Physics2D.Linecast(レイスタート、レイエンド、レイヤーマスク);

        //RaycastHit2D a;
        //var b = a.transform.GetComponent<NormalTower>();

        //b.Level++;
    }
    //塔判定
    public void TowerJud()
    {
        if (hit.transform.GetComponent<TowerBase>().ID() == 2)
        {
            hit.transform.GetComponent<NormalTower>().level++;
        }
        if (hit.transform.GetComponent<TowerBase>().ID() == 3)
        {
            hit.transform.GetComponent<FastTower>().level++;
        }
        if (hit.transform.GetComponent<TowerBase>().ID() == 4)
        {
            hit.transform.GetComponent<PowerTower>().level++;
        }
        Debug.Log("力は" + hit.transform.GetComponent<TowerBase>().Power());
        Debug.Log("レベルは" + hit.transform.GetComponent<TowerBase>().Level);
        Debug.Log("コストは" + hit.transform.GetComponent<TowerBase>().UpgraydeCost());
        MoneyManager.Instance.Money -= hit.transform.GetComponent<TowerBase>().UpgraydeCost();
    }
}