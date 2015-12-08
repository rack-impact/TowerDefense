using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public float speed;
    private Vector3 vec;
    public int HP;
    private GameObject textMoney;
    public int getMoney;

    // Use this for initialization
    void Start()
    {
        speed = GetComponent<EnemyBase>().Speed();
        vec.y = -speed;
        HP = GetComponent<EnemyBase>().HP();
        getMoney = GetComponent<EnemyBase>().Money();
        textMoney = GameObject.Find("Money");
        Debug.Log(getMoney);
        Debug.Log(speed);
        Debug.Log(HP);

    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            Destroy(gameObject);
            textMoney.GetComponent<MoneyManager>().Money += getMoney;
        }
        transform.position += vec * Time.deltaTime;
        if (transform.position.y < -11)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "UpMove")
        {
            vec.x = 0;
            vec.y = speed;
        }
        if (col.gameObject.tag == "DownMove")
        {
            vec.x = 0;
            vec.y = -speed;
        }
        if (col.gameObject.tag == "LeftMove")
        {
            vec.y = 0;
            vec.x = -speed;
        }
        if (col.gameObject.tag == "RightMove")
        {
            vec.y = 0;
            vec.x = speed;
        }
    }
}
