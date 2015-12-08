using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    public GameObject[][] field = new GameObject[12][];
    private Vector3 vec;
    private Quaternion rot;
    //[Space(100)]
    //[Range(0,100)]
    public int hp;
    //[Header("敵"),Tooltip("当たると死ぬ")]
    public GameObject[] teki;
    //[TextArea(3,6)]
    //public string memo;
    private Vector3 startPos;
    private Vector3 inisialisePos;
    public GameObject[][] nowPlace;
    public float insTime = 5;
    private float timer = 0;
    public List<GameObject> _Enemy = new List<GameObject>();
    private GameObject _pause;
    private int i = 0;

    // Use this for initialization
    void Start()
    {
        _pause = GameObject.Find("Pause");
        startPos = GameObject.Find("Masu63").transform.position;
        inisialisePos = new Vector3(50, 50, 0);
        rot = Quaternion.identity;
        for (int i = 0; i < 50; i++)
        {
            _Enemy.Add((Instantiate(teki[Random.Range(0, 3)], inisialisePos, rot)) as GameObject);
            Debug.Log(_Enemy[i]);
            _Enemy[i].SetActive(false);
            _Enemy[i].transform.parent = _pause.transform;
        }
        //var time = 0;
        //anim.Evaluate(1);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (insTime < timer)
        {
            if (i % 10 == 0)
            {
                _Enemy[i].GetComponent<Enemy>().HP += 1;
                _Enemy[i].GetComponent<Enemy>().speed += 0.5f;
                _Enemy[i].GetComponent<Enemy>().getMoney += 10;
            }
            _Enemy[i].transform.position = startPos;
            _Enemy[i].SetActive(true);
            i++;
            timer = 0;
        }
    }
}
