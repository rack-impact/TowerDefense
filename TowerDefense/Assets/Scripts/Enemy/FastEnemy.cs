using UnityEngine;
using System.Collections;

public class FastEnemy : EnemyBase
{
    public override int HP()
    {
        return 5;
    }
    public override float Speed()
    {
        return 2.5f;
    }
    public override int Power()
    {
        return 2;
    }
    public override int Money()
    {
        return 50;
    }
}
