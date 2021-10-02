

using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UniRx;
using UnityAtoms.Tags;
using System;
public class DestroyOldWeaponOnWeaponChange : MonoBehaviour
{
    [SerializeField] WeaponEntityEventReference onWeaponChanged;
    [SerializeField] EntityReference entity;
    [SerializeField] GameObjectReference weaponPivot;
    void Start()
    {
        onWeaponChanged.Event.Observe().TakeUntilDisable(this).Subscribe((weaponEntity) =>
           {
               if (weaponEntity.entity.Id == entity.Value.Id)
               {
                   var weapons = weaponPivot.Value.GetComponent<Transform>();
                   if (weapons.childCount > 1)
                   {
                       Destroy(weaponPivot.Value.GetComponent<Transform>().GetChild(0)?.gameObject);
                   }

               }
           }
        );
    }
}