using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;
using UnityAtoms.Tags;
using UnityAtoms.MonoHooks;
using UniRx;
using UniRx.Triggers;
public class UseIncreaseAmmoOnPickup : MonoBehaviour
{
    [SerializeField] ColliderGameObjectEventReference onPick;
    [SerializeField] AmmoSlotEventReference increaseAmmo;

    [SerializeField] AmmoSlotReference ammoSlot;
    // Start is called before the first frame update
    void Start()
    {
        onPick.Event.Observe()
        .TakeUntilDisable(this)
        .Subscribe((c) =>
        {
            if (c.GameObject == gameObject)
            {
                increaseAmmo.Event.Raise(ammoSlot);
            }

        });
    }


}
