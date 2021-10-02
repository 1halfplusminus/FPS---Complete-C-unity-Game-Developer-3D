using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;

[EditorIcon("atom-icon-sand")]
[CreateAssetMenu(menuName = "Atoms/Conditions/ As Tag")]
public class AsTagCondition : ColliderCondition
{
    [SerializeField]
    StringConstant tag;
    public override bool Call(Collider t1)
    {
        return t1.GetComponent<UnityAtoms.Tags.AtomTags>().HasTag(tag.Value);
    }
}
