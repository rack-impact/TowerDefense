using UnityEngine;
using System.Collections;

public abstract class TowerBase : MonoBehaviour {

	protected abstract int price{get;set;}

	public abstract int BuyPrice();

	public abstract int SellPrice();

	public abstract int Cost();

}
