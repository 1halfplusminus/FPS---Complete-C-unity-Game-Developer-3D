using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using UniRx;
public class EquipWeapon : MonoBehaviour
{
    [SerializeField] EntityReference entity;
    [SerializeField] WeaponEntityEventReference onEquipWeapon;
    [SerializeField] WeaponReference weapon;

    // Start is called before the first frame update
    void Start()
    {
        /*  Raise(weapon.Value); */
        weapon
        .ObserveEveryValueChanged((weapon) => weapon.Value)
        .TakeUntilDisable(this)
        .Subscribe(Raise);
    }
    void Raise(Weapon value)
    {
        onEquipWeapon.Event.Raise(new WeaponEntity() { entity = entity.Value, weapon = value });
    }
}
