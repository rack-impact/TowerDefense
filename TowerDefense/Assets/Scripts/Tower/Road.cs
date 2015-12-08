using UnityEngine;
using System.Collections;

public class Road : TowerBase
{
    public override string Name()
    {
        return "Road";
    }
    public override int ID()
    {
        return 1;
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

    public override int Level
    {
        get;
        set;
    }
    public override int UpgraydeCost()
    {
        return 0;
    }
    public override int BuyPrice()
    {
        return 0;
    }
    public override int SellPrice()
    {
        return 0;
    }
    public override int Cost()
    {
        return 0;
    }
    public override int Power()
    {
        return 0;
    }
    public override float ShotTime()
    {
        return 0;
    }
}
