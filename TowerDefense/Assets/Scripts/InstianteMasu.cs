using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InstianteMasu : MonoBehaviour {

    public GameObject masu;
    private int i = 0;
    private int j = 0;
    ////public TowerBase[][] status=new TowerBase[6][];  
    private GameObject[][] wall = new GameObject[12][];
    //public int sum;

    // Use this for initialization
    void Start () {

        //for(int i=0;i<6;i++) status[i]=new TowerBase[6];
        for (int i = 0; i < 12; i++) wall[i] = new GameObject[16];

    }
	
	// Update is called once per frame
	void Update () {
        for (; i < 12; i++)
        {
            for (j = 0; j < 16; j++)
            {
                //Instantiate(masu, new Vector3(-4 + i, -7.5f + j, 0), Quaternion.identity);
                wall[i][j] = Instantiate(masu, new Vector3(i, j, 0), Quaternion.identity) as GameObject;
                wall[i][j].gameObject.name = wall[i][j].gameObject.name.Replace("(Clone)", "" + ((i * 16) + j));
                //status[i][j] = nameS;
            }
        }
    }
}
