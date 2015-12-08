using UnityEngine;
using System.Collections;
using System;

public class NormalTower : TowerBase
{
    public override string Name()
    {
        return "NormalTower";
    }

    public override int ID()
    {
        return 2;
    }
    //public override int price
    //{
    //    get
    //    {
    //        return 50;
    //    }
    //    set
    //    {
    //        price = value;
    //    }
    //}
    public int level = 1;
    public override int Level
    {
        get {
            return level;
        }
        set {
            Level = level + 1;
        }
    }
    public override int UpgraydeCost()
    {
        return 100 * Level;
    }
    public override int BuyPrice()
    {
        return 150;
    }
    public override int SellPrice()
    {
        return 70;
    }
    public override int Cost()
    {
        return 50 * Level;
    }
    public override int Power()
    {
        return 2*Level;
    }
    public override float ShotTime()
    {
        return 0.7f-(0.1f * Level);
    }
}
