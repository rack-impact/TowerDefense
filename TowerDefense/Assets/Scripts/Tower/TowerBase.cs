using UnityEngine;
using System.Collections;

//ここではタワーの基本情報が書いてあります。

public abstract class TowerBase : MonoBehaviour {

    public abstract string Name();

    public abstract int ID();

    //public abstract int price { get; set; }

    //レベル
    public abstract int Level { get; set; }
    
    //購入金額
	public abstract int BuyPrice();

    //売却金額
	public abstract int SellPrice();

    //アップグレードの金額
    public abstract int UpgraydeCost();

    //一日に掛かる金額
	public abstract int Cost();

    //塔のパワー（攻撃力）
    public abstract int Power();

    //塔の撃つ速さ（弾を撃つ間隔）
    public abstract float ShotTime();
}
