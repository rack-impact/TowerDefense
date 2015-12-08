using UnityEngine;
using System.Collections;
using System;

public class PowerTower : TowerBase
{
    public override string Name()
    {
        return "PowerTower";
    }

    public override int ID()
    {
        return 4;
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
        return 70;
    }
    public override int Cost()
    {
        return 150 * Level;
    }
    public override int Power()
    {
        return 3 * Level;
    }
    public override float ShotTime()
    {
        return 1.0f - (0.12f * Level);
    }
}
