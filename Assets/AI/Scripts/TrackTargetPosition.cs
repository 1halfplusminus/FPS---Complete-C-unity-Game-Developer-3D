using UnityEngine;
using UnityAtoms.BaseAtoms;
using UniRx;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityAtoms.Tags;
public class TrackTargetPosition : MonoBehaviour
{
    [SerializeField] GameObjectReference target;

    [SerializeField] Vector3EventReference onPositionChanged;

    void Start()
    {

        IDisposable currentObserve =
        target
        .ObserveEveryValueChanged((t) => t.Value ? t.Value.transform.position : Vector3.zero)
        .TakeUntilDisable(this)
        .DistinctUntilChanged()
        .Subscribe((p) =>
        {
            Debug.Log(gameObject.name + " Update Target Position To " + p);
            onPositionChanged.Event.Raise(p);
        });
    }
}