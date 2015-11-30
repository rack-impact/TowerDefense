using UnityEngine;
using System.Collections;

public class Bill : TowerBase {

	protected override int price {
		get {
			return 20;
		}
		set {
			price=value;
		}
	}

	public override int BuyPrice()
	{
		return 60;
	}
	public override int SellPrice()
	{
		return 20;
	}
	public override int Cost()
	{
		return 30;
	}
}
