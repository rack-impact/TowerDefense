using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Idou : MonoBehaviour {

	public GameObject masu;
	public GameObject[][] field=new GameObject[12][];
	public Sprite road;
	private Vector3 vec;
	private Quaternion rot;
	public GameObject[] teki;
	private Vector3 startPos;
	private Vector3 inisialisePos;
	public GameObject[][] nowPlace;
	public float insTime=5;
    private float timer=0;
	public List<GameObject> _Enemy=new List<GameObject>();
	private GameObject _pause;
	private int i=0;

	// Use this for initialization
	void Start () {
		_pause=GameObject.Find("Pause");
		startPos=GameObject.Find("New Sprite (1)(Clone) (128)").transform.position;
		inisialisePos=new Vector3(50,50,0);

//		vec=new Vector3(-4.5f,-5.5f,0);
//
		rot=Quaternion.identity;
//
//		for(int i=0;i<12;i++) field[i]=new GameObject[9];
//	
//
//		for(int i=0;i<12;i++){
//			for(int j=0;j<9;j++){
//				field[i][j] = (Instantiate(masu,new Vector3(vec.x+j,vec.y+i,vec.z),rot))as GameObject;
//				field[i][j].gameObject.name=field[i][j].gameObject.name.Replace("(1)(Clone)",""+(i*12+j));
//			}
//		}
//		startPos=new Vector3(field[11][2].transform.position.x,field[11][2].transform.position.y,0);

		for(int i=0;i<50;i++)
		{
			_Enemy.Add((Instantiate(teki[Random.Range(0,3)],inisialisePos,rot))as GameObject);
			Debug.Log(_Enemy[i]);
			_Enemy[i].SetActive(false);
			_Enemy[i].transform.parent=_pause.transform;
		}

	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;

        if (insTime < timer)
        {
            _Enemy[i].transform.position = startPos;
            _Enemy[i].SetActive(true);
            i++;
            timer = 0;
        }
	}
}
