

using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;
using UnityAtoms.MonoHooks;
using UnityAtoms.FSM;

class AttackWhenInRange : MonoBehaviour
{
    [SerializeField] FloatReference turnSpeed;
    [SerializeField] ColliderGameObjectEventReference onRange;

    [SerializeField]
    FiniteStateMachineReference state;

    [SerializeField] StringReference attackCommand;
    [SerializeField] StringReference attackState;
    [SerializeField] HitEventReference onHit;

    ColliderGameObject attack;
    void Start()
    {
        onRange.Event.Register(OnRangeEnter);
        state.Machine.OnStateCooldown(attackState.Value, (state) =>
         {
             if (state == attackState.Value)
             {
                 FaceTarget();
             }
         }, gameObject);
    }
    // TODO: Put that somewhere else in an extension class for example
    void FaceTarget()
    {
        var targetPosition = transform.gameObject.transform.position;
        var direction = targetPosition - transform.position;
        var lookAt = Quaternion.LookRotation(direction.normalized);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookAt, turnSpeed.Value * Time.deltaTime);
    }
    public void AttackInRangeTarget()
    {
        var ennemyId = gameObject.GetInstanceID().ToString();
        var shot = new Shoot() { shooter = ennemyId, position = transform.position, direction = transform.forward };
        var hit = new Hit(shot, attack.Collider.gameObject.GetInstanceID().ToString(), transform.position);
        onHit.Event.Raise(hit);
    }
    void OnRangeEnter(ColliderGameObject e)
    {
        attack = e;
        Debug.Log(e.GameObject.name + " is in attack range " + e.Collider.name + " init attack");
        state.Machine.SetValue(attackState.Value);
    }
    private void OnDestroy()
    {
        onRange.Event.Unregister(OnRangeEnter);
    }

}