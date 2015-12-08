using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System;
using System.IO;

public class Load : MonoBehaviour {

    private int[] allMasuNumber = new int[192];

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void load ()
    {
        FileStream f = new FileStream("Assets/Map.txt", FileMode.Open, FileAccess.Read);
        BinaryReader reader = new BinaryReader(f);
        for (int i = 0; i < 192; i++)
        {  
            if (reader != null)
            {
                allMasuNumber[i] = reader.ReadInt32();
                Debug.Log("マス"+i+"番号"+allMasuNumber[i]);
            }          
        }
        reader.Close();
    }
}
