using UnityEngine;
using System.Collections;

public class FatEnemy : EnemyBase
{
    public override int HP()
    {
        return 10;
    }
    public override float Speed()
    {
        return 1.0f;
    }
    public override int Power()
    {
        return 8;
    }
    public override int Money()
    {
        return 200;
    }
}
