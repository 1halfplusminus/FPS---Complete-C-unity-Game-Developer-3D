
using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using System.Collections;

[RequireComponent(typeof(IntVariableInstancer))]
class Health : MonoBehaviour
{
    [SerializeField] HealthCreatedEventReference healthCreated;

    [SerializeField] IntVariableInstancer health;

    void Start()
    {
        StartCoroutine(Create());
    }

    IEnumerator Create()
    {
        yield return new WaitUntil(() => health.Variable != null);
        var healthCreatedEvent = new HealthCreated() { ID = gameObject.GetInstanceID(), Health = health.Variable };
        healthCreated.Event.Raise(healthCreatedEvent);
    }
}