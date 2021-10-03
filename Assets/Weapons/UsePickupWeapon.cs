using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using UniRx;
using UnityAtoms;
using UnityAtoms.MonoHooks;
public class UsePickupWeapon : MonoBehaviour
{
    [SerializeField] ColliderGameObjectEventReference onPickup;
    [SerializeField] WeaponEventReference onWeaponPickup;

    [SerializeField] WeaponReference weapon;
    void Start()
    {
        onPickup.Event.Observe().TakeUntilDisable(this).Subscribe((e) =>
        {

            if (e.GameObject == gameObject)
            {
                Debug.Log(e.Collider.name + " pick up weapon " + weapon.Value.name);
                onWeaponPickup.Event.Raise(weapon);
            }
        });
    }
}
