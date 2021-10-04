

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
        weapons
        .ObserveEveryValueChanged((v) => v.childCount).Where((c) => c > 1)
        .TakeUntilDisable(this)
        .Subscribe((c) =>
        {
            Destroy(weapons.GetChild(0)?.gameObject);
        });

    }
}