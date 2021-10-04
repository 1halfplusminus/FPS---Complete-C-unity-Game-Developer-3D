using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityAtoms.FSM;
using UniRx;
using System.Collections.Generic;
using System.Collections;

public class DisableOnState : MonoBehaviour
{
    [SerializeField] FiniteStateMachineReference fsm;

    [SerializeField] StringConstant state;

    [SerializeField] List<Behaviour> behaviours;

    void Start()
    {
        fsm.Machine.OnUpdate((d, currentState) =>
        {
            if (currentState == state.Value)
            {
                foreach (var behaviour in behaviours)
                {
                    Debug.Log("Disable " + behaviour.name);
                    behaviour.enabled = false;
                }
            }
        }, gameObject);
    }

}