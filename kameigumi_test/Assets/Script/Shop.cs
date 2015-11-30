using UnityEngine;
using System.Collections;

public class Shop : TowerBase {

	protected override int price {
		get {
			return 50;
		}
		set {
			price=value;
		}
	}
	public override int BuyPrice()
	{
		return 20;
	}
	public override int SellPrice()
	{
		return 5;
	}
	public override int Cost()
	{
		return 10;
	}
}
