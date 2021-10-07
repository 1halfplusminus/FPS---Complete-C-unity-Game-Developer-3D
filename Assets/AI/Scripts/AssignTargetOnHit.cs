using UnityEngine;
using UnityAtoms.BaseAtoms;
using UniRx;

public class AssignTargetOnHit : MonoBehaviour
{
    [SerializeField] HitEventReference onHit;
    [SerializeField] EntityReference hittedTarget;
    [SerializeField] GameObjectReference target;
    [SerializeField] GameObjectDatabase database;
    void Start()
    {
        onHit.Event.Observe()
        .TakeUntilDisable(this)
        .Subscribe((hit) =>
        {
            if (hit.hitted == hittedTarget.Value.Id)
            {

                target.Value = database.Get(hit.shoot.shooter)?.Value;
                Debug.Log(gameObject.name + " New target aquired on hit " + target.Value.gameObject.name);
            }
        });
    }
}