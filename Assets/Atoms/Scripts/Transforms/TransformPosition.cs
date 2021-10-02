using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;
[CreateAssetMenu(menuName = "Unity Atoms/Examples/TransformPosition")]
public class TransformPosition :  Vector3Vector3Function,IIsValid
{
    override public Vector3  Call(Vector3 input) {
        return new Vector3(input.x,0, input.y);
    }

    public bool IsValid()
    {
        return true;
    }
}
