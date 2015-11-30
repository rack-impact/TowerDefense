using UnityEngine;
using System.Collections;

public class BigBuilding : TowerBase {
	
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
		return 150;
	}
	public override int SellPrice()
	{
		return 70;
	}
	public override int Cost()
	{
		return 50;
	}
}
