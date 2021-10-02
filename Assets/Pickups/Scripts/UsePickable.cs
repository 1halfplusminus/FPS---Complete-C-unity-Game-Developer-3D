using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;
using UnityAtoms.Tags;
using UnityAtoms.MonoHooks;
using UniRx;
using UniRx.Triggers;
public class UsePickable : MonoBehaviour
{

    [SerializeField] GameObjectReference gameObjectRef;
    [SerializeField] ColliderGameObjectEventReference onPick;

    [SerializeField] List<StringConstant> tags;
    // Start is called before the first frame update
    void Start()
    {
        gameObjectRef.Value
        .OnTriggerEnterAsObservable()
        .TakeUntilDisable(this)
        .TakeUntilDestroy(gameObjectRef.Value)
        .Subscribe((c) =>
        {
            if (c.gameObject.HasAnyTag(tags))
            {
                Debug.Log("Collision with pickup " + c.gameObject.name + " pick up " + gameObjectRef.Value.name);
                var colliderGameobject = new ColliderGameObject();
                colliderGameobject.GameObject = gameObjectRef.Value;
                colliderGameobject.Collider = c;
                onPick.Event.Raise(colliderGameobject);
                // TODO: system should manage this
                Destroy(gameObjectRef.Value);
            }
        });
    }


}
