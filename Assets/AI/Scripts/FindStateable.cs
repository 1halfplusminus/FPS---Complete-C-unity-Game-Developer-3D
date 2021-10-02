using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;

[EditorIcon("atom-icon-sand")]
[CreateAssetMenu(menuName = "Atoms/Functions/Select Stateable")]
public class FindStateable : UnityAtoms.MonoHooks.GameObjectGameObjectFunction
{

    public FindStateable() { }
    public override GameObject Call(GameObject t1)
    {
        IStateable stateable;
        if (t1.TryGetComponent(out stateable))
        {
            return t1;
        }
        GameObject parent = t1.transform.parent.gameObject;
        do
        {
            if (parent.TryGetComponent(out stateable))
            {
                return parent;
            }
            parent = parent.transform.parent?.gameObject;
        }
        while (parent != null);
        return null;
    }
}
