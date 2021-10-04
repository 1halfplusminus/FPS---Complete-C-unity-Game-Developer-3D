using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;
using UniRx;
using System;

public class UseAmmoSlots : MonoBehaviour
{
    [SerializeField] AmmoSlots ammoSlots;

    [SerializeField] WeaponEventReference onWeaponChange;
    [SerializeField] WeaponReference equipedWeapon;
    [SerializeField] IntReference currentEquipedWeaponAmmo;
    [SerializeField] IntEventReference onCurrentEquipedWeaponAmmoChange;

    [SerializeField]
    IntReactiveProperty currentAmmoInSlot;
    void Awake()
    {
        currentAmmoInSlot = ammoSlots[equipedWeapon.Value.AmmoType];
        currentEquipedWeaponAmmo.Value = currentAmmoInSlot.Value;
        Action<int> changeAmmo = (int v) =>
         {
             currentEquipedWeaponAmmo.Value = v;
         };
        var currentSlotObserver = currentAmmoInSlot.Subscribe(changeAmmo);
        onWeaponChange.Event.Observe().TakeUntilDisable(this).Subscribe((w) =>
        {
            currentSlotObserver.Dispose();
            Debug.Log("Weapon changed get ammo type for weapon");
            currentAmmoInSlot = ammoSlots[w.AmmoType];
            currentSlotObserver = currentAmmoInSlot.Subscribe(changeAmmo);
        });

        onCurrentEquipedWeaponAmmoChange
        .Event.Observe()
        .TakeUntilDisable(this)
        .Subscribe((newValue) =>
         {
             Debug.Log("Weapon used update ammoSlot");
             currentAmmoInSlot.Value = newValue;
         }
        );
    }
}