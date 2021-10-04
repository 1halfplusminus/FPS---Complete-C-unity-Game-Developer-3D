

using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UniRx;
using UnityAtoms.Tags;
using System;
using UniRx.Triggers;
public class DestroyOldWeaponOnWeaponChange : MonoBehaviour
{
    [SerializeField] WeaponEntityEventReference onWeaponChanged;
    [SerializeField] EntityReference entity;
    [SerializeField] GameObjectReference weaponPivot;
    void Start()
    {
        var weapons = weaponPivot.Value.GetComponent<Transform>();
        var waitForTwoChildren = Observable.FromCoroutine(() =>
        {
            return new WaitUntil(() => weapons.childCount > 1);
        }).TakeUntilDisable(this);
        onWeaponChanged
        .Event
        .Observe()
        .CombineLatest(waitForTwoChildren, (l, r) => l)
        .TakeUntilDisable(this)
        .Subscribe((weaponEntity) =>
           {
               if (weaponEntity.entity.Id == entity.Value.Id)
               {

                   if (weapons.childCount > 1)
                   {
                       Destroy(weaponPivot.Value.GetComponent<Transform>().GetChild(0)?.gameObject);
                   }

               }
           }
        );
    }
}