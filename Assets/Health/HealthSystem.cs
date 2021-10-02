using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] HealthCreatedEventReference healthCreated;

    [SerializeField] AtomCollectionReference healths;

    [SerializeField] EntityEventReference entityRemoved;

    void Awake()
    {
        entityRemoved.Event.Register(EntityRemoved);
        healthCreated.Event.Register(OnNewHealth);
    }

    void OnNewHealth(HealthCreated createdHealth)
    {
        healths.Collection.GetValue().Add(createdHealth.ID.ToString(), createdHealth.Health);
        var health = healths.Collection.Value.Get<IntVariable>(createdHealth.ID.ToString());
        Debug.Log("New Healths Created " + " for " + createdHealth.ID + " with : " + health.Value);
    }
    void EntityRemoved(Entity e)
    {
        Debug.Log("Remove health for " + e.Id);
        healths.Collection.GetValue().Remove(e.Id);
    }
    void OnDestroy()
    {
        healths.Collection.Value.Clear();
        entityRemoved.Event.Unregister(EntityRemoved);
        healthCreated.Event.Unregister(OnNewHealth);
    }
}
