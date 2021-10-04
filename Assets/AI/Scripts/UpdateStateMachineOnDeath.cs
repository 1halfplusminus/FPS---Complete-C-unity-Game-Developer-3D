using UnityEngine;
using UniRx;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityAtoms.FSM;
public class UpdateStateMachineOnDeath : MonoBehaviour
{
    [SerializeField] StringConstant DEAD_STATE;
    [SerializeField] VoidBaseEventReference onDeath;
    [SerializeField] FiniteStateMachineReference stateMachine;

    bool dead;
    void Awake()
    {
        onDeath.Event.Observe()
        .TakeUntilDestroy(this)
        .Subscribe((v) =>
        {
            dead = true;
            Debug.Log("Update state machine to dead");
            stateMachine.Machine.SetValue(DEAD_STATE.Value);
        });

    }
}