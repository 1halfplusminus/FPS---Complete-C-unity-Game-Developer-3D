using UnityAtoms.BaseAtoms;
using UnityEngine;
using UniRx;
using UnityAtoms.Tags;
using System.Linq;
using System.Collections.Generic;
using UnityAtoms.MonoHooks;

public class UseReloadLight : MonoBehaviour
{
    [SerializeField] FloatReference value;

    [SerializeField] ColliderGameObjectEventReference onCollision;

    [SerializeField] FloatEventReference reloadLight;
    void Start()
    {
        onCollision
        .Event
        .Observe()
        .TakeUntilDisable(this)
        .Subscribe((c) =>
        {

            Debug.Log("Collid with a light reload");
            reloadLight.Event.Raise(value.Value);
        });
    }
}