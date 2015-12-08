using UnityEngine;
using System.Collections;
using System;

public class FastTower : TowerBase
{
    public override string Name()
    {
        return "NormalTower";
    }
    public override int ID()
    {
        return 3;
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
        get
        {
            return level;
        }
        set
        {
            Level = level + 1;
        }
    }
    public override int UpgraydeCost()
    {
        return 200*Level;
    }
    public override int BuyPrice()
    {
        return 150;
    }
    public override int SellPrice()
    {
        return 70*Level;
    }
    public override int Cost()
    {
        return 80 * Level;
    }
    public override int Power()
    {
        return 1 * Level;
    }
    public override float ShotTime()
    {
        return 0.4f - (0.05f * Level);
    }
}
