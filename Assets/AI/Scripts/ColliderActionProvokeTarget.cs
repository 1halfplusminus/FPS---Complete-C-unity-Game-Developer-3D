using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityAtoms.FSM;
[CreateAssetMenu(menuName = "Atoms/Actions/Collider Provoke Target")]
public class ColliderActionProvokeTarget : ColliderAction
{
    [SerializeField]
    StringReference provokeCommand;
    public override void Do(Collider t1)
    {
        IStateable stateable;
        if (t1.TryGetComponent(out stateable))
        {
            Debug.Log("Target " + t1.name + " provoked");
            stateable.Dispatch(provokeCommand);
        }
    }
}
