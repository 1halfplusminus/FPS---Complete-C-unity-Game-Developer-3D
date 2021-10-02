using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;
using UniRx;
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
        onWeaponChange.Event.Observe().TakeUntilDisable(this).Subscribe((w) =>
        {
            Debug.Log("Weapon changed get ammo type for weapon");
            currentAmmoInSlot = ammoSlots[w.AmmoType];
            currentEquipedWeaponAmmo.Value = currentAmmoInSlot.Value;
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