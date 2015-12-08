using UnityEngine;
using System.Collections;

public class ArmsShop : EstablishmentManager
{
    public override int UpgradePrice()
    {
        return 100;
    }
    public override int SellPrice()
    {
        return 50;
    }
    //public override int Cost()
    //{
    //    return 2;
    //}
    public override int Revenue()
    {
        return 5;
    }
    public override float RevenueTime()
    {
        return 2.0f;
    }
}
