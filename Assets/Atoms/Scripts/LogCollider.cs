using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

[CreateAssetMenu(menuName = "Atoms/Debug/Log Collider")]
public class LogCollider : ColliderAction
{
    public override void Do(Collider t1)
    {
        Debug.Log("Collider with: " + t1.gameObject.name);
    }
}
