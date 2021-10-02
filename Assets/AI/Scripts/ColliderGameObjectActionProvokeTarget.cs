using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityAtoms.FSM;
using UnityAtoms.MonoHooks;

[CreateAssetMenu(menuName = "Atoms/Actions/ColliderGameObject Provoke Target")]
public class ColliderGameObjectActionProvokeTarget : ColliderGameObjectAction
{
    [SerializeField]
    StringReference provokeCommand;

    public override void Do(ColliderGameObject t1)
    {
        Debug.Log("ColliderGameObjectActionProvokeTarget with" + t1.GameObject.name);
        IStateable stateable;
        if (t1.GameObject.TryGetComponent(out stateable))
        {
            Debug.Log("Target " + t1.GameObject.name + " provoked");
            stateable.Dispatch(provokeCommand);
        }
    }
}
