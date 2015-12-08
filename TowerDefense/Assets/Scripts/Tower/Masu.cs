using UnityEngine;
using System.Collections;
using System;

public class Masu : TowerBase {
    public override string Name()
    {
        return "Masu";
    }

    public override int ID()
    {
        return 0;
    }

 //   public override int price {
	//	get {
	//		return 50;
	//	}
	//	set {
	//		price=value;
	//	}
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
