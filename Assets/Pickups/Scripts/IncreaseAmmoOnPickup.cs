using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;
using UnityAtoms.Tags;
using UnityAtoms.MonoHooks;
using UniRx;
using UniRx.Triggers;
public class IncreaseAmmoOnPickup : MonoBehaviour
{
    [SerializeField] AmmoSlotEventReference increaseAmmo;
    [SerializeField] AmmoSlots ammoSlots;

    void Awake()
    {
        increaseAmmo.Event
        .Observe()
        .TakeUntilDisable(this)
        .Subscribe((s) =>
        {
            Debug.Log("Increase ammo for " + s.ammoType + " : " + s.amount);
            ammoSlots.Add(s);
        });
    }
}