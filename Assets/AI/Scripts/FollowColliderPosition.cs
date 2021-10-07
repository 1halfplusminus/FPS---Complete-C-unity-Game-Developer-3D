using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;
using UniRx;
using UnityAtoms.MonoHooks;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityAtoms.Tags;
public class FollowColliderPosition : MonoBehaviour
{
    [SerializeField] Vector3EventReference onPositionChanged;

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
            currentTracked = collider
            .gameObject
            .transform
            .ObserveEveryValueChanged((t) => t.position)
            .DistinctUntilChanged()
            .TakeUntilDisable(this)
            .Subscribe((p) =>
            {
                Debug.Log("New Target acquire "
                 + collider.name
                 + " tracking target position: " + p);
                onPositionChanged.Event.Raise(p);
            });
        });
    }
}