using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.FSM;
using UnityAtoms.BaseAtoms;

[RequireComponent(typeof(Renderer))]
public class AngryOnProvoked : MonoBehaviour
{
    [SerializeField] StringConstant ANGRY_STATE;
    [SerializeField] FiniteStateMachineReference state;
    private void Start()
    {
        var renderer = GetComponent<Renderer>();
        var materialPropertyBlock = new MaterialPropertyBlock();
        materialPropertyBlock.SetInteger("_Angry", 1);
        state.Machine.OnUpdate((d, s) =>
        {
            if (s == ANGRY_STATE.Value)
            {
                renderer.SetPropertyBlock(materialPropertyBlock);
            }
        }, gameObject);
    }
}
