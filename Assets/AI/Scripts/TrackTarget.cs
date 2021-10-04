using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.AI;
using System.Linq;
using UnityAtoms.FSM;
using UnityAtoms;

[RequireComponent(typeof(NavMeshAgent))]
public class TrackTarget : MonoBehaviour, IStateable
{
    [SerializeField]
    StringConstant PROVOKE_COMMAND;
    [SerializeField] StringConstant IDLE_STATE;
    [SerializeField] StringConstant MOVING_STATE;

    [SerializeField]
    StringConstant provokedState;
    [SerializeField] Vector3EventReference positionChanged;

    [SerializeField] Vector3Reference velocity;
    NavMeshAgent navMeshAgent;

    Vector3 targetPosition;

    [SerializeField]
    FiniteStateMachineReference state;

    [SerializeField]
    HitEventReference onHit;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        positionChanged.Event.Register(OnTargetPositionChange);
        onHit.Event.Register(OnHit);
        state.Machine.OnUpdate((delta, value) =>
        {

            if (value == provokedState.Value)
            {
                Track();
            }
        }, gameObject);

    }
    void OnHit(Hit hit)
    {
        //TODO: get id from somewhere else
        if (hit.hitted == gameObject.GetInstanceID().ToString())
        {
            state.Machine.Dispatch(PROVOKE_COMMAND.Value);
        }
    }
    void OnDestroy()
    {
        positionChanged.Event.Unregister(OnTargetPositionChange);
        onHit.Event.Unregister(OnHit);
    }

    void OnTargetPositionChange(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;
    }

    public void Track()
    {
        StartCoroutine(NavAgentTrack());
    }

    IEnumerator NavAgentTrack()
    {
        IsAgentMoving();
        navMeshAgent.SetDestination(targetPosition);
        yield return new WaitForEndOfFrame();
        yield return NavAgentTrack();
    }

    void IsAgentMoving()
    {
        if (navMeshAgent.velocity != Vector3.zero)
        {
            state.Machine.SetValue(MOVING_STATE.Value);
        }
        else
        {
            state.Machine.SetValue(IDLE_STATE.Value);
        }
        velocity.Value = navMeshAgent.velocity;
    }
    public void LogState(FSMTransitionData transitionData)
    {
        Debug.Log("transition data:" + transitionData.FromState + " => " + transitionData.ToState);
    }
    public void LogState(StringPair pair)
    {
        Debug.Log(pair.Item2 + " => " + pair.Item1);
    }

    public void Dispatch(string command)
    {
        state.Machine.Dispatch(command);
    }

    public void OnDisable()
    {
        Debug.Log(gameObject.name + " Disable Track");
        StopAllCoroutines();
    }
}
