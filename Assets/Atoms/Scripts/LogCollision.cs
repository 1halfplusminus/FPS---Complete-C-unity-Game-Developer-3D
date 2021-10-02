using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
[CreateAssetMenu(menuName = "Atoms/Debug/Log Collision")]
public class LogCollision : CollisionAction
{
    public override void Do(Collision t1)
    {
        Debug.Log("Collision with :" + t1.gameObject.name);
    }
}
