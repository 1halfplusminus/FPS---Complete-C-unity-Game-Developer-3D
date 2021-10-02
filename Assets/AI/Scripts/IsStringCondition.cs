using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;

[EditorIcon("atom-icon-sand")]
[CreateAssetMenu(menuName = "Atoms/Conditions/ Is String")]
public class IsStringCondition : StringCondition
{
    [SerializeField]
    StringReference stringRef;
    public override bool Call(string value)
    {
        return value == stringRef.Value;
    }
}
