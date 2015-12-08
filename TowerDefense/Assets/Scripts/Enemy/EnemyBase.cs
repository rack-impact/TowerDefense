using UnityEngine;
using System.Collections;

public abstract class EnemyBase : MonoBehaviour
{
    public abstract int HP();

    public abstract float Speed();

    public abstract int Power();

    public abstract int Money();
}
