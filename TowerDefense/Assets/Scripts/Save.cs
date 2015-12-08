using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System;
using System.IO;

public class Save : MonoBehaviour {

    private GameObject[] allMasu=new GameObject[192];

    // Use this for initialization
    void Start() {
         
    }

    // Update is called once per frame
    void Update() {
    }

    public void save()
    {      
        FileStream f = new FileStream("Assets/Map.txt", FileMode.Create, FileAccess.Write);
        BinaryWriter writer = new BinaryWriter(f);
        for (int i = 0; i < 192; i++)
        {
            allMasu[i] = GameObject.Find("Masu" + i);
            writer.Write(allMasu[i].GetComponent<TowerBase>().ID());
        }
        writer.Close();
    }
}

