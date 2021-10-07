using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;
using UniRx;
using UnityAtoms.MonoHooks;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityAtoms.Tags;
public class AssignTargetOnCollider : MonoBehaviour
{
    [SerializeField] GameObjectReference target;

    [SerializeField] ColliderEventInstancer onCollider;

    [SerializeField] List<StringConstant> tags;
    void Start()
    {
        var tagsList = tags.Select((t) => t.Value).ToList();
        IDisposable currentTracked = null;
        onCollider
        .Event
        .Observe()
        .TakeUntilDisable(this)
        .Subscribe((collider) =>
        {
            if (!collider.gameObject.HasAnyTag(tagsList)) { return; }
            if (currentTracked != null) { currentTracked.Dispose(); }
            Debug.Log(gameObject.name + " New target aquired on collider " + collider.gameObject.name);
            target.Value = collider.gameObject;
        });
    }
}