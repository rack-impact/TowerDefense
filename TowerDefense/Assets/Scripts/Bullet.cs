using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public GameObject tower;
	private GameObject target;
	private Vector3 vec;
    private float bulletSpeed;
    private int count;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < tower.GetComponent<Shot>().Enemy.Count; i++)
        {
            if (tower.GetComponent<Shot>().Enemy[i] != null)
            {
                target = tower.GetComponent<Shot>().Enemy[i];
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (tower.GetComponent<Shot>().Enemy.Count == 0)
        {
            Destroy(gameObject);
        }
        bulletSpeed += 0.25f * Time.deltaTime;
        transform.position = Vector3.Lerp(transform.position,target.transform.position, bulletSpeed);
	
	}
	void OnTriggerEnter2D(Collider2D col) {
			if(col.gameObject.tag=="Enemy"){
			col.GetComponent<Enemy>().HP-= tower.GetComponent<TowerBase>().Power();
			Destroy(gameObject);
//			transform.position+=col.transform.position*Time.deltaTime;
		}
	}
}
