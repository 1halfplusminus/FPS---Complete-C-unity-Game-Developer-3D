using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.FSM;

[RequireComponent(typeof(Animator))]
public class EnemyStateSync : MonoBehaviour
{
    [SerializeField] StringConstant ATTACK_STATE;
    [SerializeField] StringConstant PROVOKED_STATE;

    [SerializeField] StringConstant IDLE_STATE;
    [SerializeField] StringConstant MOVE_STATE;
    [SerializeField] FiniteStateMachineReference stateMachine;
    [SerializeField] Vector3Reference velocity;
    // Start is called before the first frame update
    void Start()
    {
        var animator = GetComponent<Animator>();
        var lastState = stateMachine.Machine.Value;
        stateMachine.Machine.OnStateCooldown(ATTACK_STATE.Value, (state) =>
       {
           if (state == ATTACK_STATE.Value)
           {
               animator.SetTrigger("Attacking");
           }

       }, gameObject);
        stateMachine.Machine.OnUpdate((t, s) =>
        {
            if (s == PROVOKED_STATE.Value)
            {
                animator.SetTrigger("Provoked");
            }

            if (s != lastState)
            {
                if (s == IDLE_STATE.Value)
                {
                    animator.SetFloat("Move", 0f);
                }
                if (s == MOVE_STATE.Value)
                {
                    Debug.Log("Change animator state to move");
                    animator.SetFloat("Move", Mathf.Abs(velocity.Value.z));
                }
                lastState = s;
            }

        }, gameObject);
    }

}
