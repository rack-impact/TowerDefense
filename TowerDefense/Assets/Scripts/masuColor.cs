using UnityEngine;
using System.Collections;

public class masuColor : MonoBehaviour
{

    public SpriteRenderer rend;
    //	private int i=0;
    //	private int j=0;
    private RaycastHit2D hit;
    private GameObject oldSitei;

    // Use this for initialization
    void Start()
    {
        rend = gameObject.GetComponent<SpriteRenderer>();
        //		towers[0] = new Bill();
        //		towers[1] = new Shop();

        //		int sum =0;
        //		for(int i=0;i<towers.Length;i++)
        //			sum+= towers[i].Cost();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 aTapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);
        if (aCollider2d)
        {
            int layerMask = ~(1 << LayerMask.NameToLayer("Tower") | 1<< LayerMask.NameToLayer("Enemy"));
            hit = Physics2D.Raycast(aTapPoint, -Vector2.up, 100, layerMask);
            //Debug.Log("hit = " + hit.transform.name);
            if (hit)
            {
                if (oldSitei != hit.transform.gameObject)
                {
                    hit.transform.GetComponent<SpriteRenderer>().material.color = Color.red;
                    if(oldSitei)
                        oldSitei.GetComponent<SpriteRenderer>().material.color = Color.white;
                    oldSitei = hit.transform.gameObject;
                }
            }
        }
        else
        {
            if (oldSitei)
                oldSitei.GetComponent<SpriteRenderer>().material.color = Color.white;
            oldSitei = null;
        }
        //void OnMouseEnter()
        //{
        //    rend.material.color = Color.red;
        //}
        ////void OnMouseOver()
        ////{
        ////    rend.material.color -= new Color(0.1F, 0, 0) * Time.deltaTime;
        ////}
        //void OnMouseExit()
        //{
        //    rend.material.color = Color.white;
    }

}
