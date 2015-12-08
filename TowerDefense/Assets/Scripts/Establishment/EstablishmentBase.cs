using UnityEngine;
using System.Collections;

public abstract class EstablishmentManager : MonoBehaviour
{
    public abstract int UpgradePrice();

    public abstract int SellPrice();

   // public abstract int Cost();

    public abstract int Revenue();

    public abstract float RevenueTime();
}
