using UnityEngine;
using System.Collections;

public class Masu : TowerBase {

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
}
