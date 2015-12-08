using UnityEngine;
using System.Collections;

public class NormalEnemy : EnemyBase
{
    public override int HP()
    {
        return 7;
    }
    public override float Speed()
    {
        return 1.5f;
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
